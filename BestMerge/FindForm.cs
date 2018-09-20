using System.Globalization;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BestMerge
{
    [ProvideToolboxControl("BestMerge.FindForm", false)]
    public partial class FindForm : Form
    {
        public FindForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format(CultureInfo.CurrentUICulture, "We are inside {0}.Button1_Click()", this.ToString()));
        }

        private void CbTeamProjectCollectionSelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void cbMergeTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnGetChangesetsClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CbTeamProjectSelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CbMergeFromSelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LwChangesetsColumnClick(object sender, ColumnClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LwChangesetsDoubleClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LwChangesetsKeyDown(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BwWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BwWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FindFormLoad(object sender, EventArgs e)
        {
            //TODO App Form Load
        }
    }
}
