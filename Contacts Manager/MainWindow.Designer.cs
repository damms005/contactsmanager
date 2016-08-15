using MetroFramework;
using MetroFramework.Forms;


namespace Contacts_Manager
{
	partial class MainWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.metroButton_get_fields_vcf = new MetroFramework.Controls.MetroButton();
			this.metroButton2 = new MetroFramework.Controls.MetroButton();
			this.metroTxtbx_cwd = new MetroFramework.Controls.MetroTextBox();
			this.metroTextBox_vcf_fields = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel_status = new MetroFramework.Controls.MetroLabel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.folderSelectDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
			this.tabPage1 = new MetroFramework.Controls.MetroTabPage();
			this.tabPage2 = new MetroFramework.Controls.MetroTabPage();
			this.metroTextBox_csvMergerOutput = new MetroFramework.Controls.MetroTextBox();
			this.metroButton_set_output_csv_hybrid = new MetroFramework.Controls.MetroButton();
			this.metroTextBox_hybrid_csv_output_name = new MetroFramework.Controls.MetroTextBox();
			this.metroButton_merge_csvs = new MetroFramework.Controls.MetroButton();
			this.metroLabel_csv2 = new MetroFramework.Controls.MetroLabel();
			this.metroButton_select_csv2 = new MetroFramework.Controls.MetroButton();
			this.metroLabel_csv1 = new MetroFramework.Controls.MetroLabel();
			this.metroButton_csv1 = new MetroFramework.Controls.MetroButton();
			this.tabPage3 = new MetroFramework.Controls.MetroTabPage();
			this.tabPage4 = new MetroFramework.Controls.MetroTabPage();
			this.metroLabel_output_vcf = new MetroFramework.Controls.MetroLabel();
			this.metroButton_convert_csv_to_vcf = new MetroFramework.Controls.MetroButton();
			this.metroTextBox_output = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel_selected_csv = new MetroFramework.Controls.MetroLabel();
			this.metroButn_select_csv = new MetroFramework.Controls.MetroButton();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.statusStrip1.SuspendLayout();
			this.metroTabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.SuspendLayout();
			// 
			// metroButton_get_fields_vcf
			// 
			this.metroButton_get_fields_vcf.AutoSize = true;
			this.metroButton_get_fields_vcf.Location = new System.Drawing.Point( 27, 278 );
			this.metroButton_get_fields_vcf.Name = "metroButton_get_fields_vcf";
			this.metroButton_get_fields_vcf.Size = new System.Drawing.Size( 87, 23 );
			this.metroButton_get_fields_vcf.TabIndex = 0;
			this.metroButton_get_fields_vcf.Text = "Get VCF Fields";
			this.metroButton_get_fields_vcf.UseSelectable = true;
			this.metroButton_get_fields_vcf.Click += new System.EventHandler( this.get_vcf_fields_Click );
			// 
			// metroButton2
			// 
			this.metroButton2.AutoSize = true;
			this.metroButton2.Location = new System.Drawing.Point( 27, 14 );
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new System.Drawing.Size( 87, 23 );
			this.metroButton2.TabIndex = 1;
			this.metroButton2.Text = "Set cwd";
			this.metroButton2.UseSelectable = true;
			this.metroButton2.Click += new System.EventHandler( this.metroButton_selectCWD_Click );
			// 
			// metroTxtbx_cwd
			// 
			this.metroTxtbx_cwd.Lines = new string[0];
			this.metroTxtbx_cwd.Location = new System.Drawing.Point( 120, 14 );
			this.metroTxtbx_cwd.MaxLength = 32767;
			this.metroTxtbx_cwd.Name = "metroTxtbx_cwd";
			this.metroTxtbx_cwd.PasswordChar = '\0';
			this.metroTxtbx_cwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.metroTxtbx_cwd.SelectedText = "";
			this.metroTxtbx_cwd.Size = new System.Drawing.Size( 585, 23 );
			this.metroTxtbx_cwd.TabIndex = 2;
			this.metroTxtbx_cwd.UseSelectable = true;
			// 
			// metroTextBox_vcf_fields
			// 
			this.metroTextBox_vcf_fields.Lines = new string[0];
			this.metroTextBox_vcf_fields.Location = new System.Drawing.Point( 27, 87 );
			this.metroTextBox_vcf_fields.MaxLength = 32767;
			this.metroTextBox_vcf_fields.Multiline = true;
			this.metroTextBox_vcf_fields.Name = "metroTextBox_vcf_fields";
			this.metroTextBox_vcf_fields.PasswordChar = '\0';
			this.metroTextBox_vcf_fields.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.metroTextBox_vcf_fields.SelectedText = "";
			this.metroTextBox_vcf_fields.Size = new System.Drawing.Size( 300, 185 );
			this.metroTextBox_vcf_fields.TabIndex = 3;
			this.metroTextBox_vcf_fields.UseSelectable = true;
			this.metroTextBox_vcf_fields.WordWrap = false;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point( 27, 65 );
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size( 73, 19 );
			this.metroLabel1.TabIndex = 4;
			this.metroLabel1.Text = "VCF Fields:";
			// 
			// metroLabel_status
			// 
			this.metroLabel_status.AutoSize = true;
			this.metroLabel_status.Location = new System.Drawing.Point( 132, 282 );
			this.metroLabel_status.Name = "metroLabel_status";
			this.metroLabel_status.Size = new System.Drawing.Size( 18, 19 );
			this.metroLabel_status.TabIndex = 5;
			this.metroLabel_status.Text = "...";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3} );
			this.statusStrip1.Location = new System.Drawing.Point( 20, 431 );
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size( 711, 22 );
			this.statusStrip1.TabIndex = 7;
			this.statusStrip1.Text = "...";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size( 16, 17 );
			this.toolStripStatusLabel1.Text = "...";
			this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size( 118, 17 );
			this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size( 118, 17 );
			this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
			// 
			// metroTabControl1
			// 
			this.metroTabControl1.Controls.Add( this.tabPage1 );
			this.metroTabControl1.Controls.Add( this.tabPage2 );
			this.metroTabControl1.Controls.Add( this.tabPage3 );
			this.metroTabControl1.Controls.Add( this.tabPage4 );
			this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.metroTabControl1.Location = new System.Drawing.Point( 20, 60 );
			this.metroTabControl1.Name = "metroTabControl1";
			this.metroTabControl1.SelectedIndex = 1;
			this.metroTabControl1.Size = new System.Drawing.Size( 711, 371 );
			this.metroTabControl1.TabIndex = 8;
			this.metroTabControl1.UseSelectable = true;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add( this.metroLabel_status );
			this.tabPage1.Controls.Add( this.metroButton2 );
			this.tabPage1.Controls.Add( this.metroLabel1 );
			this.tabPage1.Controls.Add( this.metroButton_get_fields_vcf );
			this.tabPage1.Controls.Add( this.metroTextBox_vcf_fields );
			this.tabPage1.Controls.Add( this.metroTxtbx_cwd );
			this.tabPage1.HorizontalScrollbarBarColor = true;
			this.tabPage1.HorizontalScrollbarHighlightOnWheel = false;
			this.tabPage1.HorizontalScrollbarSize = 10;
			this.tabPage1.Location = new System.Drawing.Point( 4, 38 );
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size( 703, 329 );
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "     VCard     ";
			this.tabPage1.VerticalScrollbarBarColor = true;
			this.tabPage1.VerticalScrollbarHighlightOnWheel = false;
			this.tabPage1.VerticalScrollbarSize = 10;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add( this.metroTextBox_csvMergerOutput );
			this.tabPage2.Controls.Add( this.metroButton_set_output_csv_hybrid );
			this.tabPage2.Controls.Add( this.metroTextBox_hybrid_csv_output_name );
			this.tabPage2.Controls.Add( this.metroButton_merge_csvs );
			this.tabPage2.Controls.Add( this.metroLabel_csv2 );
			this.tabPage2.Controls.Add( this.metroButton_select_csv2 );
			this.tabPage2.Controls.Add( this.metroLabel_csv1 );
			this.tabPage2.Controls.Add( this.metroButton_csv1 );
			this.tabPage2.HorizontalScrollbarBarColor = true;
			this.tabPage2.HorizontalScrollbarHighlightOnWheel = false;
			this.tabPage2.HorizontalScrollbarSize = 10;
			this.tabPage2.Location = new System.Drawing.Point( 4, 38 );
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size( 703, 329 );
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "CSV Merger";
			this.tabPage2.VerticalScrollbarBarColor = true;
			this.tabPage2.VerticalScrollbarHighlightOnWheel = false;
			this.tabPage2.VerticalScrollbarSize = 10;
			// 
			// metroTextBox_csvMergerOutput
			// 
			this.metroTextBox_csvMergerOutput.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
			| System.Windows.Forms.AnchorStyles.Left )
			| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.metroTextBox_csvMergerOutput.Lines = new string[0];
			this.metroTextBox_csvMergerOutput.Location = new System.Drawing.Point( 3, 140 );
			this.metroTextBox_csvMergerOutput.MaxLength = 32767;
			this.metroTextBox_csvMergerOutput.Multiline = true;
			this.metroTextBox_csvMergerOutput.Name = "metroTextBox_csvMergerOutput";
			this.metroTextBox_csvMergerOutput.PasswordChar = '\0';
			this.metroTextBox_csvMergerOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.metroTextBox_csvMergerOutput.SelectedText = "";
			this.metroTextBox_csvMergerOutput.Size = new System.Drawing.Size( 672, 186 );
			this.metroTextBox_csvMergerOutput.TabIndex = 10;
			this.metroTextBox_csvMergerOutput.UseSelectable = true;
			this.metroTextBox_csvMergerOutput.WordWrap = false;
			// 
			// metroButton_set_output_csv_hybrid
			// 
			this.metroButton_set_output_csv_hybrid.AutoSize = true;
			this.metroButton_set_output_csv_hybrid.Location = new System.Drawing.Point( 3, 79 );
			this.metroButton_set_output_csv_hybrid.Name = "metroButton_set_output_csv_hybrid";
			this.metroButton_set_output_csv_hybrid.Size = new System.Drawing.Size( 105, 23 );
			this.metroButton_set_output_csv_hybrid.TabIndex = 9;
			this.metroButton_set_output_csv_hybrid.Text = "Set output file";
			this.metroButton_set_output_csv_hybrid.UseSelectable = true;
			// 
			// metroTextBox_hybrid_csv_output_name
			// 
			this.metroTextBox_hybrid_csv_output_name.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
			| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.metroTextBox_hybrid_csv_output_name.Lines = new string[0];
			this.metroTextBox_hybrid_csv_output_name.Location = new System.Drawing.Point( 114, 79 );
			this.metroTextBox_hybrid_csv_output_name.MaxLength = 32767;
			this.metroTextBox_hybrid_csv_output_name.Name = "metroTextBox_hybrid_csv_output_name";
			this.metroTextBox_hybrid_csv_output_name.PasswordChar = '\0';
			this.metroTextBox_hybrid_csv_output_name.PromptText = "Output csv filename...";
			this.metroTextBox_hybrid_csv_output_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.metroTextBox_hybrid_csv_output_name.SelectedText = "";
			this.metroTextBox_hybrid_csv_output_name.Size = new System.Drawing.Size( 561, 23 );
			this.metroTextBox_hybrid_csv_output_name.TabIndex = 8;
			this.metroTextBox_hybrid_csv_output_name.UseSelectable = true;
			// 
			// metroButton_merge_csvs
			// 
			this.metroButton_merge_csvs.Location = new System.Drawing.Point( 3, 111 );
			this.metroButton_merge_csvs.Name = "metroButton_merge_csvs";
			this.metroButton_merge_csvs.Size = new System.Drawing.Size( 105, 23 );
			this.metroButton_merge_csvs.TabIndex = 7;
			this.metroButton_merge_csvs.Text = "Merge!";
			this.metroButton_merge_csvs.UseSelectable = true;
			this.metroButton_merge_csvs.Click += new System.EventHandler( this.metroButton_merge_csvs_Click );
			// 
			// metroLabel_csv2
			// 
			this.metroLabel_csv2.AutoSize = true;
			this.metroLabel_csv2.Location = new System.Drawing.Point( 114, 54 );
			this.metroLabel_csv2.Name = "metroLabel_csv2";
			this.metroLabel_csv2.Size = new System.Drawing.Size( 18, 19 );
			this.metroLabel_csv2.TabIndex = 5;
			this.metroLabel_csv2.Text = "...";
			// 
			// metroButton_select_csv2
			// 
			this.metroButton_select_csv2.AutoSize = true;
			this.metroButton_select_csv2.Location = new System.Drawing.Point( 3, 50 );
			this.metroButton_select_csv2.Name = "metroButton_select_csv2";
			this.metroButton_select_csv2.Size = new System.Drawing.Size( 105, 23 );
			this.metroButton_select_csv2.TabIndex = 4;
			this.metroButton_select_csv2.Text = "Select second csv";
			this.metroButton_select_csv2.UseSelectable = true;
			this.metroButton_select_csv2.Click += new System.EventHandler( this.metroButton_select_csv2_Click );
			// 
			// metroLabel_csv1
			// 
			this.metroLabel_csv1.AutoSize = true;
			this.metroLabel_csv1.Location = new System.Drawing.Point( 114, 25 );
			this.metroLabel_csv1.Name = "metroLabel_csv1";
			this.metroLabel_csv1.Size = new System.Drawing.Size( 18, 19 );
			this.metroLabel_csv1.TabIndex = 3;
			this.metroLabel_csv1.Text = "...";
			// 
			// metroButton_csv1
			// 
			this.metroButton_csv1.AutoSize = true;
			this.metroButton_csv1.Location = new System.Drawing.Point( 3, 21 );
			this.metroButton_csv1.Name = "metroButton_csv1";
			this.metroButton_csv1.Size = new System.Drawing.Size( 105, 23 );
			this.metroButton_csv1.TabIndex = 2;
			this.metroButton_csv1.Text = "Select first csv";
			this.metroButton_csv1.UseSelectable = true;
			this.metroButton_csv1.Click += new System.EventHandler( this.metroButton_csv1_Click );
			// 
			// tabPage3
			// 
			this.tabPage3.HorizontalScrollbarBarColor = true;
			this.tabPage3.HorizontalScrollbarHighlightOnWheel = false;
			this.tabPage3.HorizontalScrollbarSize = 10;
			this.tabPage3.Location = new System.Drawing.Point( 4, 38 );
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size( 703, 329 );
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "     VCF Merger  ";
			this.tabPage3.VerticalScrollbarBarColor = true;
			this.tabPage3.VerticalScrollbarHighlightOnWheel = false;
			this.tabPage3.VerticalScrollbarSize = 10;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add( this.metroLabel_output_vcf );
			this.tabPage4.Controls.Add( this.metroButton_convert_csv_to_vcf );
			this.tabPage4.Controls.Add( this.metroTextBox_output );
			this.tabPage4.Controls.Add( this.metroLabel_selected_csv );
			this.tabPage4.Controls.Add( this.metroButn_select_csv );
			this.tabPage4.HorizontalScrollbarBarColor = true;
			this.tabPage4.HorizontalScrollbarHighlightOnWheel = false;
			this.tabPage4.HorizontalScrollbarSize = 10;
			this.tabPage4.Location = new System.Drawing.Point( 4, 38 );
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size( 703, 329 );
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "   CSV - VCF";
			this.tabPage4.VerticalScrollbarBarColor = true;
			this.tabPage4.VerticalScrollbarHighlightOnWheel = false;
			this.tabPage4.VerticalScrollbarSize = 10;
			// 
			// metroLabel_output_vcf
			// 
			this.metroLabel_output_vcf.AutoSize = true;
			this.metroLabel_output_vcf.Location = new System.Drawing.Point( 84, 59 );
			this.metroLabel_output_vcf.Name = "metroLabel_output_vcf";
			this.metroLabel_output_vcf.Size = new System.Drawing.Size( 18, 19 );
			this.metroLabel_output_vcf.TabIndex = 6;
			this.metroLabel_output_vcf.Text = "...";
			// 
			// metroButton_convert_csv_to_vcf
			// 
			this.metroButton_convert_csv_to_vcf.Location = new System.Drawing.Point( 3, 55 );
			this.metroButton_convert_csv_to_vcf.Name = "metroButton_convert_csv_to_vcf";
			this.metroButton_convert_csv_to_vcf.Size = new System.Drawing.Size( 75, 25 );
			this.metroButton_convert_csv_to_vcf.TabIndex = 5;
			this.metroButton_convert_csv_to_vcf.Text = "Convert";
			this.metroButton_convert_csv_to_vcf.UseSelectable = true;
			this.metroButton_convert_csv_to_vcf.Click += new System.EventHandler( this.metroButton_convert_csv_to__Click );
			// 
			// metroTextBox_output
			// 
			this.metroTextBox_output.Lines = new string[] {
        "..."};
			this.metroTextBox_output.Location = new System.Drawing.Point( 3, 84 );
			this.metroTextBox_output.MaxLength = 32767;
			this.metroTextBox_output.Multiline = true;
			this.metroTextBox_output.Name = "metroTextBox_output";
			this.metroTextBox_output.PasswordChar = '\0';
			this.metroTextBox_output.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.metroTextBox_output.SelectedText = "";
			this.metroTextBox_output.Size = new System.Drawing.Size( 342, 242 );
			this.metroTextBox_output.TabIndex = 4;
			this.metroTextBox_output.Text = "...";
			this.metroTextBox_output.UseSelectable = true;
			this.metroTextBox_output.WordWrap = false;
			// 
			// metroLabel_selected_csv
			// 
			this.metroLabel_selected_csv.AutoSize = true;
			this.metroLabel_selected_csv.Location = new System.Drawing.Point( 84, 30 );
			this.metroLabel_selected_csv.Name = "metroLabel_selected_csv";
			this.metroLabel_selected_csv.Size = new System.Drawing.Size( 18, 19 );
			this.metroLabel_selected_csv.TabIndex = 3;
			this.metroLabel_selected_csv.Text = "...";
			// 
			// metroButn_select_csv
			// 
			this.metroButn_select_csv.Location = new System.Drawing.Point( 3, 26 );
			this.metroButn_select_csv.Name = "metroButn_select_csv";
			this.metroButn_select_csv.Size = new System.Drawing.Size( 75, 25 );
			this.metroButn_select_csv.TabIndex = 2;
			this.metroButn_select_csv.Text = "Select csv file";
			this.metroButn_select_csv.UseSelectable = true;
			this.metroButn_select_csv.Click += new System.EventHandler( this.metroButn_select_csv_Click );
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
			this.ClientSize = new System.Drawing.Size( 751, 473 );
			this.Controls.Add( this.metroTabControl1 );
			this.Controls.Add( this.statusStrip1 );
			this.Name = "MainWindow";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
			this.Text = "Contacts Manager";
			this.statusStrip1.ResumeLayout( false );
			this.statusStrip1.PerformLayout();
			this.metroTabControl1.ResumeLayout( false );
			this.tabPage1.ResumeLayout( false );
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout( false );
			this.tabPage2.PerformLayout();
			this.tabPage4.ResumeLayout( false );
			this.tabPage4.PerformLayout();
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroButton metroButton_get_fields_vcf;
		private MetroFramework.Controls.MetroButton metroButton2;
		private MetroFramework.Controls.MetroTextBox metroTxtbx_cwd;
		private MetroFramework.Controls.MetroTextBox metroTextBox_vcf_fields;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel_status;
		private System.Windows.Forms.FolderBrowserDialog folderSelectDialog;
		public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		public System.Windows.Forms.StatusStrip statusStrip1;
		private MetroFramework.Controls.MetroTabControl metroTabControl1;
		private MetroFramework.Controls.MetroTabPage tabPage1;
		private MetroFramework.Controls.MetroTabPage tabPage4;
		private MetroFramework.Controls.MetroTabPage tabPage3;
		private MetroFramework.Controls.MetroTextBox metroTextBox_output;
		private MetroFramework.Controls.MetroLabel metroLabel_selected_csv;
		private MetroFramework.Controls.MetroButton metroButn_select_csv;
		private MetroFramework.Controls.MetroLabel metroLabel_output_vcf;
		private MetroFramework.Controls.MetroButton metroButton_convert_csv_to_vcf;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private MetroFramework.Controls.MetroTabPage tabPage2;
		private MetroFramework.Controls.MetroTextBox metroTextBox_hybrid_csv_output_name;
		private MetroFramework.Controls.MetroButton metroButton_merge_csvs;
		private MetroFramework.Controls.MetroLabel metroLabel_csv2;
		private MetroFramework.Controls.MetroButton metroButton_select_csv2;
		private MetroFramework.Controls.MetroLabel metroLabel_csv1;
		private MetroFramework.Controls.MetroButton metroButton_csv1;
		private MetroFramework.Controls.MetroButton metroButton_set_output_csv_hybrid;
		private MetroFramework.Controls.MetroTextBox metroTextBox_csvMergerOutput;
	}
}

