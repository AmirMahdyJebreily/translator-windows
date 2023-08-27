namespace MyTranslatorWindows
{
    partial class frmTranslator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            translatorPage = new Microsoft.Web.WebView2.WinForms.WebView2();
            contextMenuStrip1 = new ContextMenuStrip(components);
            notifyIcon1 = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)translatorPage).BeginInit();
            SuspendLayout();
            // 
            // translatorPage
            // 
            translatorPage.AllowExternalDrop = true;
            translatorPage.CreationProperties = null;
            translatorPage.DefaultBackgroundColor = Color.White;
            translatorPage.Dock = DockStyle.Fill;
            translatorPage.Location = new Point(0, 0);
            translatorPage.Name = "translatorPage";
            translatorPage.Size = new Size(454, 561);
            translatorPage.Source = new Uri("https://google.com", UriKind.Absolute);
            translatorPage.TabIndex = 0;
            translatorPage.ZoomFactor = 1D;
            translatorPage.NavigationStarting += translatorPage_NavigationStarting;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            contextMenuStrip1.Text = "Settings";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "Translator";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // frmTranslator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 561);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(translatorPage);
            Name = "frmTranslator";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "My Translator Window";
            Load += frmTranslator_Load;
            ((System.ComponentModel.ISupportInitialize)translatorPage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 translatorPage;
        private ContextMenuStrip contextMenuStrip1;
        private NotifyIcon notifyIcon1;
    }
}