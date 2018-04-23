namespace DataBindingXMLIntoDataSet {
    partial class XtraReport1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.lbTrademark = new DevExpress.XtraReports.UI.XRLabel();
            this.lbModel = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbModel,
            this.lbTrademark});
            this.Detail.Height = 41;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbTrademark
            // 
            this.lbTrademark.Location = new System.Drawing.Point(17, 8);
            this.lbTrademark.Name = "lbTrademark";
            this.lbTrademark.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbTrademark.Size = new System.Drawing.Size(192, 25);
            this.lbTrademark.Text = "lbTrademark";
            // 
            // lbModel
            // 
            this.lbModel.Location = new System.Drawing.Point(217, 8);
            this.lbModel.Name = "lbModel";
            this.lbModel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbModel.Size = new System.Drawing.Size(217, 25);
            this.lbModel.Text = "lbModel";
            // 
            // XtraReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail});
            this.Version = "8.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        public DevExpress.XtraReports.UI.XRLabel lbTrademark;
        public DevExpress.XtraReports.UI.XRLabel lbModel;
    }
}
