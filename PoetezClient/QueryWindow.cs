using System;
using System.Windows.Forms;
using ColorCode;
using MarkupConverter;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace PoetezClient
{
    public partial class QueryWindow : Form
    {
        MySqlConnection DBConnection;
        UpdateData Data;

        CodeColorizer Colorizer;
        LockController Locker;
        Font QueryFont;
        Regex Validator;
        int CursorPosition;

        public QueryWindow(MySqlConnection connection)
        {
            DBConnection = connection;

            InitializeComponent();
            Colorizer = new CodeColorizer();
            QueryFont = new Font("Courier New", 15);
            QueryEditor.Font = QueryFont;
            Validator = new Regex(@"^select(?!(?:;|insert|update|delete))", RegexOptions.IgnoreCase);
        }

        private void QueryEditor_TextChanged(object sender, EventArgs e)
        {
            if (Locker.QueryEditor)
                return;
            
            CursorPosition = QueryEditor.SelectionStart;
            {
                Locker.LockQueryEditor();
                ApplyQueryEditor(Colorize(QueryEditor.Text));
                Locker.UnlockQueryEditor();
            }
        }

        private void ExecuteBtn_Click(object sender, EventArgs e)
        {
            var cmdText = QueryEditor.Text;

            if (!Validate(cmdText))
                throw new PoetezClientException("Разрешены запросы только типа SELECT");

            var cmd = new MySqlCommand(cmdText, DBConnection);

            {
                Data = new UpdateData(cmd);
                ResultTable.DataSource = new BindingSource(Data.Table, null);
            }
        }

        private bool Validate(string cmdText)
        {
            return Validator.IsMatch(cmdText);
        }

        private string Colorize(string original)
        {
            return Colorizer.Colorize(original, Languages.Sql);
        }

        private void ApplyQueryEditor(string text)
        {
            QueryEditor.Rtf = HtmlToRtfConverter.ConvertHtmlToRtf(text);
            QueryEditor.SelectAll();
            QueryEditor.SelectionFont = QueryFont;
            QueryEditor.DeselectAll();
            QueryEditor.SelectionStart = CursorPosition;
        }
    }

    public struct LockController
    {
        public bool QueryEditor { get; private set; }

        public void LockQueryEditor()
        {
            QueryEditor = true;
        }

        public void UnlockQueryEditor()
        {
            QueryEditor = false;
        }
    }
}
