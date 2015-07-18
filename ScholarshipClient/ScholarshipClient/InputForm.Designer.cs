namespace ScholarshipClient
{
    partial class InputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputForm));
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.exportButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.nextPageButton = new System.Windows.Forms.Button();
            this.beforePageButton = new System.Windows.Forms.Button();
            this.baseLabelPanel = new System.Windows.Forms.Panel();
            this.studyTitleLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lessonNumberPanel1 = new ScholarshipClient.GUI.LessonNumberPanel();
            this.syntheticRankPanel1 = new ScholarshipClient.GUI.SyntheticRankPanel();
            this.scoleRankPanel1 = new ScholarshipClient.GUI.ScoleRankPanel();
            this.studentNumbersPanel1 = new ScholarshipClient.GUI.StudentNumbersPanel();
            this.schemasPanel1 = new ScholarshipClient.GUI.SchemasPanel();
            this.academicPanel1 = new ScholarshipClient.GUI.AcademicPanel();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.studyPanel = new System.Windows.Forms.Panel();
            this.reasonPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textAreaPanel3 = new ScholarshipClient.GUI.TextAreaPanel();
            this.textAreaPanel2 = new ScholarshipClient.GUI.TextAreaPanel();
            this.textAreaPanel1 = new ScholarshipClient.GUI.TextAreaPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.reasonTitlelabel = new System.Windows.Forms.Label();
            this.basePanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.studentYearsPanel1 = new ScholarshipClient.GUI.StudentYearsPanel();
            this.professionPanel1 = new ScholarshipClient.GUI.ProfessionPanel();
            this.nationPanel1 = new ScholarshipClient.GUI.NationPanel();
            this.idCardPanel2 = new ScholarshipClient.GUI.IDCardPanel();
            this.phonePanel2 = new ScholarshipClient.GUI.PhonePanel();
            this.studentSexPanel2 = new ScholarshipClient.GUI.StudentSexPanel();
            this.studentPolicityPanel2 = new ScholarshipClient.GUI.StudentPolicityPanel();
            this.studentNamePanel2 = new ScholarshipClient.GUI.StudentNamePanel();
            this.studentIDPanel2 = new ScholarshipClient.GUI.StudentIDPanel();
            this.studyLabelPanel = new System.Windows.Forms.Panel();
            this.baseTitleLabel = new System.Windows.Forms.Label();
            this.buttonPanel.SuspendLayout();
            this.baseLabelPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.inputPanel.SuspendLayout();
            this.studyPanel.SuspendLayout();
            this.reasonPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.basePanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.studyLabelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.exportButton);
            this.buttonPanel.Controls.Add(this.importButton);
            this.buttonPanel.Controls.Add(this.nextPageButton);
            this.buttonPanel.Controls.Add(this.beforePageButton);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(0, 440);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(772, 51);
            this.buttonPanel.TabIndex = 0;
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(396, 14);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 11;
            this.exportButton.Text = "导出";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // importButton
            // 
            this.importButton.BackColor = System.Drawing.SystemColors.Control;
            this.importButton.Location = new System.Drawing.Point(315, 14);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(75, 23);
            this.importButton.TabIndex = 10;
            this.importButton.Text = "导入";
            this.importButton.UseVisualStyleBackColor = false;
            // 
            // nextPageButton
            // 
            this.nextPageButton.Location = new System.Drawing.Point(685, 14);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(75, 23);
            this.nextPageButton.TabIndex = 12;
            this.nextPageButton.Text = "下一页";
            this.nextPageButton.UseVisualStyleBackColor = true;
            this.nextPageButton.Click += new System.EventHandler(this.nextPageButton_Click);
            // 
            // beforePageButton
            // 
            this.beforePageButton.Location = new System.Drawing.Point(12, 14);
            this.beforePageButton.Name = "beforePageButton";
            this.beforePageButton.Size = new System.Drawing.Size(75, 23);
            this.beforePageButton.TabIndex = 9;
            this.beforePageButton.Text = "上一页";
            this.beforePageButton.UseVisualStyleBackColor = true;
            this.beforePageButton.Click += new System.EventHandler(this.beforePageButton_Click);
            // 
            // baseLabelPanel
            // 
            this.baseLabelPanel.Controls.Add(this.studyTitleLabel);
            this.baseLabelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.baseLabelPanel.Location = new System.Drawing.Point(0, 0);
            this.baseLabelPanel.Name = "baseLabelPanel";
            this.baseLabelPanel.Size = new System.Drawing.Size(766, 32);
            this.baseLabelPanel.TabIndex = 1;
            // 
            // studyTitleLabel
            // 
            this.studyTitleLabel.AutoSize = true;
            this.studyTitleLabel.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.studyTitleLabel.Location = new System.Drawing.Point(315, 4);
            this.studyTitleLabel.Name = "studyTitleLabel";
            this.studyTitleLabel.Size = new System.Drawing.Size(149, 20);
            this.studyTitleLabel.TabIndex = 0;
            this.studyTitleLabel.Text = "学习及获奖情况";
            this.studyTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lessonNumberPanel1);
            this.panel3.Controls.Add(this.syntheticRankPanel1);
            this.panel3.Controls.Add(this.scoleRankPanel1);
            this.panel3.Controls.Add(this.studentNumbersPanel1);
            this.panel3.Controls.Add(this.schemasPanel1);
            this.panel3.Controls.Add(this.academicPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(766, 399);
            this.panel3.TabIndex = 2;
            // 
            // lessonNumberPanel1
            // 
            this.lessonNumberPanel1.AutoSize = true;
            this.lessonNumberPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lessonNumberPanel1.Content = "";
            this.lessonNumberPanel1.ContentWidth = 135;
            this.lessonNumberPanel1.Error = "";
            this.lessonNumberPanel1.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.lessonNumberPanel1.Location = new System.Drawing.Point(275, 181);
            this.lessonNumberPanel1.Name = "lessonNumberPanel1";
            this.lessonNumberPanel1.Size = new System.Drawing.Size(220, 39);
            this.lessonNumberPanel1.TabIndex = 4;
            this.lessonNumberPanel1.Title = "必修课数量：";
            // 
            // syntheticRankPanel1
            // 
            this.syntheticRankPanel1.AutoSize = true;
            this.syntheticRankPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.syntheticRankPanel1.Content = "";
            this.syntheticRankPanel1.ContentWidth = 135;
            this.syntheticRankPanel1.Error = "";
            this.syntheticRankPanel1.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.syntheticRankPanel1.Location = new System.Drawing.Point(263, 136);
            this.syntheticRankPanel1.Name = "syntheticRankPanel1";
            this.syntheticRankPanel1.Size = new System.Drawing.Size(232, 39);
            this.syntheticRankPanel1.TabIndex = 3;
            this.syntheticRankPanel1.Title = "综合考评排名：";
            // 
            // scoleRankPanel1
            // 
            this.scoleRankPanel1.AutoSize = true;
            this.scoleRankPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scoleRankPanel1.Content = "";
            this.scoleRankPanel1.ContentWidth = 135;
            this.scoleRankPanel1.Error = "";
            this.scoleRankPanel1.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.scoleRankPanel1.Location = new System.Drawing.Point(287, 91);
            this.scoleRankPanel1.Name = "scoleRankPanel1";
            this.scoleRankPanel1.Size = new System.Drawing.Size(208, 39);
            this.scoleRankPanel1.TabIndex = 2;
            this.scoleRankPanel1.Title = "成绩排名：";
            // 
            // studentNumbersPanel1
            // 
            this.studentNumbersPanel1.AutoSize = true;
            this.studentNumbersPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.studentNumbersPanel1.Content = "";
            this.studentNumbersPanel1.ContentWidth = 135;
            this.studentNumbersPanel1.Error = "";
            this.studentNumbersPanel1.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.studentNumbersPanel1.Location = new System.Drawing.Point(275, 50);
            this.studentNumbersPanel1.Name = "studentNumbersPanel1";
            this.studentNumbersPanel1.Size = new System.Drawing.Size(220, 39);
            this.studentNumbersPanel1.TabIndex = 1;
            this.studentNumbersPanel1.Title = "专业总人数：";
            // 
            // schemasPanel1
            // 
            this.schemasPanel1.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.schemasPanel1.Location = new System.Drawing.Point(99, 226);
            this.schemasPanel1.Name = "schemasPanel1";
            this.schemasPanel1.Size = new System.Drawing.Size(619, 142);
            this.schemasPanel1.TabIndex = 5;
            // 
            // academicPanel1
            // 
            this.academicPanel1.AutoSize = true;
            this.academicPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.academicPanel1.ContentWidth = 131;
            this.academicPanel1.DataSource = ((object)(resources.GetObject("academicPanel1.DataSource")));
            this.academicPanel1.Editable = false;
            this.academicPanel1.Error = "";
            this.academicPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.academicPanel1.Location = new System.Drawing.Point(311, 6);
            this.academicPanel1.Name = "academicPanel1";
            this.academicPanel1.Size = new System.Drawing.Size(184, 38);
            this.academicPanel1.TabIndex = 0;
            this.academicPanel1.Title = "学院：";
            // 
            // inputPanel
            // 
            this.inputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPanel.Controls.Add(this.reasonPanel);
            this.inputPanel.Controls.Add(this.basePanel);
            this.inputPanel.Controls.Add(this.studyPanel);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPanel.Location = new System.Drawing.Point(0, 0);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(772, 440);
            this.inputPanel.TabIndex = 12;
            // 
            // studyPanel
            // 
            this.studyPanel.Controls.Add(this.panel3);
            this.studyPanel.Controls.Add(this.baseLabelPanel);
            this.studyPanel.Location = new System.Drawing.Point(3, 3);
            this.studyPanel.Name = "studyPanel";
            this.studyPanel.Size = new System.Drawing.Size(766, 431);
            this.studyPanel.TabIndex = 3;
            // 
            // reasonPanel
            // 
            this.reasonPanel.Controls.Add(this.panel2);
            this.reasonPanel.Controls.Add(this.panel4);
            this.reasonPanel.Location = new System.Drawing.Point(3, 3);
            this.reasonPanel.Name = "reasonPanel";
            this.reasonPanel.Size = new System.Drawing.Size(766, 431);
            this.reasonPanel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textAreaPanel3);
            this.panel2.Controls.Add(this.textAreaPanel2);
            this.panel2.Controls.Add(this.textAreaPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 399);
            this.panel2.TabIndex = 2;
            // 
            // textAreaPanel3
            // 
            this.textAreaPanel3.Content = "";
            this.textAreaPanel3.Date = new System.DateTime(2015, 7, 7, 15, 47, 16, 239);
            this.textAreaPanel3.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.textAreaPanel3.Location = new System.Drawing.Point(10, 292);
            this.textAreaPanel3.Name = "textAreaPanel3";
            this.textAreaPanel3.NowNumber = 0;
            this.textAreaPanel3.Size = new System.Drawing.Size(748, 93);
            this.textAreaPanel3.TabIndex = 2;
            this.textAreaPanel3.Title = "院系意见";
            this.textAreaPanel3.WordNumber = 100;
            // 
            // textAreaPanel2
            // 
            this.textAreaPanel2.Content = "";
            this.textAreaPanel2.Date = new System.DateTime(2015, 7, 7, 15, 47, 16, 239);
            this.textAreaPanel2.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.textAreaPanel2.Location = new System.Drawing.Point(10, 181);
            this.textAreaPanel2.Name = "textAreaPanel2";
            this.textAreaPanel2.NowNumber = 0;
            this.textAreaPanel2.Size = new System.Drawing.Size(748, 104);
            this.textAreaPanel2.TabIndex = 1;
            this.textAreaPanel2.Title = "推荐理由（90-100字）";
            this.textAreaPanel2.WordNumber = 100;
            // 
            // textAreaPanel1
            // 
            this.textAreaPanel1.Content = "";
            this.textAreaPanel1.Date = new System.DateTime(2015, 7, 7, 15, 47, 16, 239);
            this.textAreaPanel1.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.textAreaPanel1.Location = new System.Drawing.Point(10, 6);
            this.textAreaPanel1.Name = "textAreaPanel1";
            this.textAreaPanel1.NowNumber = 0;
            this.textAreaPanel1.Size = new System.Drawing.Size(748, 168);
            this.textAreaPanel1.TabIndex = 0;
            this.textAreaPanel1.Title = "申请理由（190-200字）";
            this.textAreaPanel1.WordNumber = 200;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.reasonTitlelabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(766, 32);
            this.panel4.TabIndex = 1;
            // 
            // reasonTitlelabel
            // 
            this.reasonTitlelabel.AutoSize = true;
            this.reasonTitlelabel.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reasonTitlelabel.Location = new System.Drawing.Point(286, 5);
            this.reasonTitlelabel.Name = "reasonTitlelabel";
            this.reasonTitlelabel.Size = new System.Drawing.Size(229, 20);
            this.reasonTitlelabel.TabIndex = 0;
            this.reasonTitlelabel.Text = "申请推荐理由及审核意见";
            this.reasonTitlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // basePanel
            // 
            this.basePanel.Controls.Add(this.panel6);
            this.basePanel.Controls.Add(this.studyLabelPanel);
            this.basePanel.Location = new System.Drawing.Point(3, 3);
            this.basePanel.Name = "basePanel";
            this.basePanel.Size = new System.Drawing.Size(766, 431);
            this.basePanel.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.studentYearsPanel1);
            this.panel6.Controls.Add(this.professionPanel1);
            this.panel6.Controls.Add(this.nationPanel1);
            this.panel6.Controls.Add(this.idCardPanel2);
            this.panel6.Controls.Add(this.phonePanel2);
            this.panel6.Controls.Add(this.studentSexPanel2);
            this.panel6.Controls.Add(this.studentPolicityPanel2);
            this.panel6.Controls.Add(this.studentNamePanel2);
            this.panel6.Controls.Add(this.studentIDPanel2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 32);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(766, 399);
            this.panel6.TabIndex = 2;
            // 
            // studentYearsPanel1
            // 
            this.studentYearsPanel1.AutoSize = true;
            this.studentYearsPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.studentYearsPanel1.ContentWidth = 70;
            this.studentYearsPanel1.DataSource = ((object)(resources.GetObject("studentYearsPanel1.DataSource")));
            this.studentYearsPanel1.Editable = false;
            this.studentYearsPanel1.Error = "";
            this.studentYearsPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.studentYearsPanel1.Location = new System.Drawing.Point(315, 269);
            this.studentYearsPanel1.Name = "studentYearsPanel1";
            this.studentYearsPanel1.Size = new System.Drawing.Size(123, 38);
            this.studentYearsPanel1.TabIndex = 6;
            this.studentYearsPanel1.Title = "年制：";
            // 
            // professionPanel1
            // 
            this.professionPanel1.AutoSize = true;
            this.professionPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.professionPanel1.Content = "";
            this.professionPanel1.ContentWidth = 150;
            this.professionPanel1.Error = "";
            this.professionPanel1.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.professionPanel1.Location = new System.Drawing.Point(293, 225);
            this.professionPanel1.Name = "professionPanel1";
            this.professionPanel1.Size = new System.Drawing.Size(223, 39);
            this.professionPanel1.TabIndex = 5;
            this.professionPanel1.Title = "专业全称：";
            // 
            // nationPanel1
            // 
            this.nationPanel1.AutoSize = true;
            this.nationPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nationPanel1.ContentWidth = 100;
            this.nationPanel1.DataSource = ((object)(resources.GetObject("nationPanel1.DataSource")));
            this.nationPanel1.Editable = false;
            this.nationPanel1.Error = "";
            this.nationPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nationPanel1.Location = new System.Drawing.Point(311, 180);
            this.nationPanel1.Name = "nationPanel1";
            this.nationPanel1.Size = new System.Drawing.Size(153, 38);
            this.nationPanel1.TabIndex = 4;
            this.nationPanel1.Title = "民族：";
            // 
            // idCardPanel2
            // 
            this.idCardPanel2.AutoSize = true;
            this.idCardPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.idCardPanel2.Content = "";
            this.idCardPanel2.ContentWidth = 150;
            this.idCardPanel2.Error = "";
            this.idCardPanel2.ErrorID = 0;
            this.idCardPanel2.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.idCardPanel2.Location = new System.Drawing.Point(280, 358);
            this.idCardPanel2.Name = "idCardPanel2";
            this.idCardPanel2.Size = new System.Drawing.Size(235, 39);
            this.idCardPanel2.TabIndex = 8;
            this.idCardPanel2.Title = "身份证号码：";
            // 
            // phonePanel2
            // 
            this.phonePanel2.AutoSize = true;
            this.phonePanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.phonePanel2.Content = "";
            this.phonePanel2.ContentWidth = 98;
            this.phonePanel2.Error = "";
            this.phonePanel2.ErrorID = 0;
            this.phonePanel2.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.phonePanel2.Location = new System.Drawing.Point(293, 313);
            this.phonePanel2.Name = "phonePanel2";
            this.phonePanel2.Size = new System.Drawing.Size(171, 39);
            this.phonePanel2.TabIndex = 7;
            this.phonePanel2.Title = "联系电话：";
            // 
            // studentSexPanel2
            // 
            this.studentSexPanel2.AutoSize = true;
            this.studentSexPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.studentSexPanel2.ContentWidth = 50;
            this.studentSexPanel2.DataSource = new string[] {
        "男",
        "女"};
            this.studentSexPanel2.Editable = false;
            this.studentSexPanel2.Error = "";
            this.studentSexPanel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.studentSexPanel2.Location = new System.Drawing.Point(315, 93);
            this.studentSexPanel2.Name = "studentSexPanel2";
            this.studentSexPanel2.Size = new System.Drawing.Size(100, 38);
            this.studentSexPanel2.TabIndex = 2;
            this.studentSexPanel2.Title = "性别：";
            // 
            // studentPolicityPanel2
            // 
            this.studentPolicityPanel2.AutoSize = true;
            this.studentPolicityPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.studentPolicityPanel2.ContentWidth = 100;
            this.studentPolicityPanel2.DataSource = new string[] {
        "群众",
        "共青团员",
        "中共预备党员",
        "中共党员"};
            this.studentPolicityPanel2.Editable = false;
            this.studentPolicityPanel2.Error = "";
            this.studentPolicityPanel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.studentPolicityPanel2.Location = new System.Drawing.Point(290, 137);
            this.studentPolicityPanel2.Name = "studentPolicityPanel2";
            this.studentPolicityPanel2.Size = new System.Drawing.Size(174, 38);
            this.studentPolicityPanel2.TabIndex = 3;
            this.studentPolicityPanel2.Title = "政治面貌：";
            // 
            // studentNamePanel2
            // 
            this.studentNamePanel2.AutoSize = true;
            this.studentNamePanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.studentNamePanel2.Content = "";
            this.studentNamePanel2.ContentWidth = 100;
            this.studentNamePanel2.Error = "";
            this.studentNamePanel2.ErrorID = 0;
            this.studentNamePanel2.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.studentNamePanel2.Location = new System.Drawing.Point(315, 48);
            this.studentNamePanel2.Name = "studentNamePanel2";
            this.studentNamePanel2.Size = new System.Drawing.Size(149, 39);
            this.studentNamePanel2.TabIndex = 1;
            this.studentNamePanel2.Title = "姓名：";
            // 
            // studentIDPanel2
            // 
            this.studentIDPanel2.AutoSize = true;
            this.studentIDPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.studentIDPanel2.Content = "";
            this.studentIDPanel2.ContentWidth = 100;
            this.studentIDPanel2.EnrollMonth = 0;
            this.studentIDPanel2.EnrollYear = 0;
            this.studentIDPanel2.Error = "";
            this.studentIDPanel2.ErrorID = 0;
            this.studentIDPanel2.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.studentIDPanel2.Location = new System.Drawing.Point(315, 3);
            this.studentIDPanel2.Name = "studentIDPanel2";
            this.studentIDPanel2.Size = new System.Drawing.Size(149, 39);
            this.studentIDPanel2.TabIndex = 0;
            this.studentIDPanel2.Title = "学号：";
            // 
            // studyLabelPanel
            // 
            this.studyLabelPanel.Controls.Add(this.baseTitleLabel);
            this.studyLabelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.studyLabelPanel.Location = new System.Drawing.Point(0, 0);
            this.studyLabelPanel.Name = "studyLabelPanel";
            this.studyLabelPanel.Size = new System.Drawing.Size(766, 32);
            this.studyLabelPanel.TabIndex = 1;
            // 
            // baseTitleLabel
            // 
            this.baseTitleLabel.AutoSize = true;
            this.baseTitleLabel.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseTitleLabel.Location = new System.Drawing.Point(326, 4);
            this.baseTitleLabel.Name = "baseTitleLabel";
            this.baseTitleLabel.Size = new System.Drawing.Size(89, 20);
            this.baseTitleLabel.TabIndex = 0;
            this.baseTitleLabel.Text = "基本情况";
            this.baseTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 491);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.buttonPanel);
            this.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.Name = "InputForm";
            this.Text = "国奖申请表填写助手";
            this.buttonPanel.ResumeLayout(false);
            this.baseLabelPanel.ResumeLayout(false);
            this.baseLabelPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.inputPanel.ResumeLayout(false);
            this.studyPanel.ResumeLayout(false);
            this.reasonPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.basePanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.studyLabelPanel.ResumeLayout(false);
            this.studyLabelPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button nextPageButton;
        private System.Windows.Forms.Button beforePageButton;
        private System.Windows.Forms.Panel baseLabelPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label studyTitleLabel;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Panel studyPanel;
        private System.Windows.Forms.Panel basePanel;
        private System.Windows.Forms.Panel panel6;
        private GUI.IDCardPanel idCardPanel2;
        private GUI.PhonePanel phonePanel2;
        private GUI.StudentSexPanel studentSexPanel2;
        private GUI.StudentPolicityPanel studentPolicityPanel2;
        private GUI.StudentNamePanel studentNamePanel2;
        private GUI.StudentIDPanel studentIDPanel2;
        private System.Windows.Forms.Panel studyLabelPanel;
        private System.Windows.Forms.Label baseTitleLabel;
        private GUI.AcademicPanel academicPanel1;
        private System.Windows.Forms.Panel reasonPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label reasonTitlelabel;
        private GUI.TextAreaPanel textAreaPanel3;
        private GUI.TextAreaPanel textAreaPanel2;
        private GUI.TextAreaPanel textAreaPanel1;
        private GUI.ProfessionPanel professionPanel1;
        private GUI.NationPanel nationPanel1;
        private GUI.SchemasPanel schemasPanel1;
        private GUI.LessonNumberPanel lessonNumberPanel1;
        private GUI.SyntheticRankPanel syntheticRankPanel1;
        private GUI.ScoleRankPanel scoleRankPanel1;
        private GUI.StudentNumbersPanel studentNumbersPanel1;
        private GUI.StudentYearsPanel studentYearsPanel1;
    }
}