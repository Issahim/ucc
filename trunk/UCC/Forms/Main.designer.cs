namespace UCC.Forms
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.kryptonPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_Patrol = new System.Windows.Forms.RadioButton();
            this.rb_Pull = new System.Windows.Forms.RadioButton();
            this.rb_Combat = new System.Windows.Forms.RadioButton();
            this.actionList = new System.Windows.Forms.ListBox();
            this.UCCAlgo = new System.Windows.Forms.Button();
            this.BCopy = new System.Windows.Forms.Button();
            this.BCPAdd = new System.Windows.Forms.Button();
            this.BWizard = new System.Windows.Forms.Button();
            this.BRemoveAction = new System.Windows.Forms.Button();
            this.bCLose = new System.Windows.Forms.Button();
            this.BAddAction = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.BDownAction = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.BupAction = new System.Windows.Forms.Button();
            this.bLoad = new System.Windows.Forms.Button();
            this.editActionNav = new System.Windows.Forms.TabControl();
            this.generalActionPage = new System.Windows.Forms.TabPage();
            this.kryptonPanel4 = new System.Windows.Forms.Panel();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.kryptonPage7 = new System.Windows.Forms.TabPage();
            this.kryptonPanel3 = new System.Windows.Forms.Panel();
            this.conditionsList = new DevExpress.XtraEditors.ListBoxControl();
            this.propertyGrid2 = new System.Windows.Forms.PropertyGrid();
            this.kryptonGroupBox1 = new System.Windows.Forms.GroupBox();
            this.b_RemoveCond = new System.Windows.Forms.Button();
            this.b_AddCond = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.kryptonPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.editActionNav.SuspendLayout();
            this.generalActionPage.SuspendLayout();
            this.kryptonPanel4.SuspendLayout();
            this.kryptonPage7.SuspendLayout();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conditionsList)).BeginInit();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.panel1);
            this.kryptonPanel.Controls.Add(this.UCCAlgo);
            this.kryptonPanel.Controls.Add(this.BCopy);
            this.kryptonPanel.Controls.Add(this.BCPAdd);
            this.kryptonPanel.Controls.Add(this.BWizard);
            this.kryptonPanel.Controls.Add(this.BRemoveAction);
            this.kryptonPanel.Controls.Add(this.bCLose);
            this.kryptonPanel.Controls.Add(this.BAddAction);
            this.kryptonPanel.Controls.Add(this.bClear);
            this.kryptonPanel.Controls.Add(this.BDownAction);
            this.kryptonPanel.Controls.Add(this.bSave);
            this.kryptonPanel.Controls.Add(this.BupAction);
            this.kryptonPanel.Controls.Add(this.bLoad);
            this.kryptonPanel.Controls.Add(this.editActionNav);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(746, 358);
            this.kryptonPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_Patrol);
            this.panel1.Controls.Add(this.rb_Pull);
            this.panel1.Controls.Add(this.rb_Combat);
            this.panel1.Controls.Add(this.actionList);
            this.panel1.Location = new System.Drawing.Point(17, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 221);
            this.panel1.TabIndex = 12;
            // 
            // rb_Patrol
            // 
            this.rb_Patrol.AutoSize = true;
            this.rb_Patrol.Location = new System.Drawing.Point(153, 12);
            this.rb_Patrol.Name = "rb_Patrol";
            this.rb_Patrol.Size = new System.Drawing.Size(52, 17);
            this.rb_Patrol.TabIndex = 14;
            this.rb_Patrol.Text = "Patrol";
            this.rb_Patrol.UseVisualStyleBackColor = true;
            this.rb_Patrol.CheckedChanged += new System.EventHandler(this.rb_Patrol_CheckedChanged);
            // 
            // rb_Pull
            // 
            this.rb_Pull.AutoSize = true;
            this.rb_Pull.Location = new System.Drawing.Point(90, 12);
            this.rb_Pull.Name = "rb_Pull";
            this.rb_Pull.Size = new System.Drawing.Size(42, 17);
            this.rb_Pull.TabIndex = 13;
            this.rb_Pull.Text = "Pull";
            this.rb_Pull.UseVisualStyleBackColor = true;
            this.rb_Pull.CheckedChanged += new System.EventHandler(this.rb_Patrol_CheckedChanged);
            // 
            // rb_Combat
            // 
            this.rb_Combat.AutoSize = true;
            this.rb_Combat.Checked = true;
            this.rb_Combat.Location = new System.Drawing.Point(15, 12);
            this.rb_Combat.Name = "rb_Combat";
            this.rb_Combat.Size = new System.Drawing.Size(61, 17);
            this.rb_Combat.TabIndex = 12;
            this.rb_Combat.TabStop = true;
            this.rb_Combat.Text = "Combat";
            this.rb_Combat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rb_Combat.UseVisualStyleBackColor = true;
            this.rb_Combat.CheckedChanged += new System.EventHandler(this.rb_Patrol_CheckedChanged);
            // 
            // actionList
            // 
            this.actionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionList.Location = new System.Drawing.Point(0, 35);
            this.actionList.Name = "actionList";
            this.actionList.Size = new System.Drawing.Size(215, 186);
            this.actionList.TabIndex = 11;
            this.actionList.SelectedValueChanged += new System.EventHandler(this.combatList_SelectedValueChanged);
            // 
            // UCCAlgo
            // 
            this.UCCAlgo.Image = global::UCC.Properties.Resources.help;
            this.UCCAlgo.Location = new System.Drawing.Point(330, 313);
            this.UCCAlgo.Name = "UCCAlgo";
            this.UCCAlgo.Size = new System.Drawing.Size(30, 34);
            this.UCCAlgo.TabIndex = 10;
            this.UCCAlgo.Click += new System.EventHandler(this.UCCAlgo_Click);
            // 
            // BCopy
            // 
            this.BCopy.Image = global::UCC.Properties.Resources.copy;
            this.BCopy.Location = new System.Drawing.Point(238, 124);
            this.BCopy.Name = "BCopy";
            this.BCopy.Size = new System.Drawing.Size(25, 25);
            this.BCopy.TabIndex = 9;
            this.BCopy.Click += new System.EventHandler(this.BCopy_Click);
            // 
            // BCPAdd
            // 
            this.BCPAdd.Image = global::UCC.Properties.Resources.paste;
            this.BCPAdd.Location = new System.Drawing.Point(122, 239);
            this.BCPAdd.Name = "BCPAdd";
            this.BCPAdd.Size = new System.Drawing.Size(110, 30);
            this.BCPAdd.TabIndex = 8;
            this.BCPAdd.Text = "Clipboard Add";
            this.BCPAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BCPAdd.Click += new System.EventHandler(this.BCPAdd_Click);
            // 
            // BWizard
            // 
            this.BWizard.Image = global::UCC.Properties.Resources.wizard_icon;
            this.BWizard.Location = new System.Drawing.Point(17, 239);
            this.BWizard.Name = "BWizard";
            this.BWizard.Size = new System.Drawing.Size(99, 30);
            this.BWizard.TabIndex = 7;
            this.BWizard.Text = "Wizard";
            this.BWizard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BWizard.Click += new System.EventHandler(this.BWizard_Click);
            // 
            // BRemoveAction
            // 
            this.BRemoveAction.Image = global::UCC.Properties.Resources.remove;
            this.BRemoveAction.Location = new System.Drawing.Point(142, 273);
            this.BRemoveAction.Name = "BRemoveAction";
            this.BRemoveAction.Size = new System.Drawing.Size(90, 30);
            this.BRemoveAction.TabIndex = 6;
            this.BRemoveAction.Text = "Remove";
            this.BRemoveAction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BRemoveAction.Click += new System.EventHandler(this.BRemoveAction_Click);
            // 
            // bCLose
            // 
            this.bCLose.Image = global::UCC.Properties.Resources.close;
            this.bCLose.Location = new System.Drawing.Point(644, 313);
            this.bCLose.Name = "bCLose";
            this.bCLose.Size = new System.Drawing.Size(90, 34);
            this.bCLose.TabIndex = 6;
            this.bCLose.Text = "Close";
            this.bCLose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bCLose.Click += new System.EventHandler(this.bCLose_Click);
            // 
            // BAddAction
            // 
            this.BAddAction.Image = global::UCC.Properties.Resources.add;
            this.BAddAction.Location = new System.Drawing.Point(17, 273);
            this.BAddAction.Name = "BAddAction";
            this.BAddAction.Size = new System.Drawing.Size(119, 30);
            this.BAddAction.TabIndex = 5;
            this.BAddAction.Text = "Add";
            this.BAddAction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BAddAction.Click += new System.EventHandler(this.BAddAction_Click);
            // 
            // bClear
            // 
            this.bClear.Image = global::UCC.Properties.Resources._new;
            this.bClear.Location = new System.Drawing.Point(225, 313);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(90, 34);
            this.bClear.TabIndex = 5;
            this.bClear.Text = "New";
            this.bClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // BDownAction
            // 
            this.BDownAction.Image = global::UCC.Properties.Resources.default2;
            this.BDownAction.Location = new System.Drawing.Point(238, 181);
            this.BDownAction.Name = "BDownAction";
            this.BDownAction.Size = new System.Drawing.Size(25, 25);
            this.BDownAction.TabIndex = 4;
            this.BDownAction.Click += new System.EventHandler(this.BDownAction_Click);
            // 
            // bSave
            // 
            this.bSave.Image = global::UCC.Properties.Resources.Save_icon;
            this.bSave.Location = new System.Drawing.Point(120, 313);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(90, 34);
            this.bSave.TabIndex = 4;
            this.bSave.Text = "Save ...";
            this.bSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // BupAction
            // 
            this.BupAction.Image = global::UCC.Properties.Resources._default;
            this.BupAction.Location = new System.Drawing.Point(238, 71);
            this.BupAction.Name = "BupAction";
            this.BupAction.Size = new System.Drawing.Size(25, 25);
            this.BupAction.TabIndex = 3;
            this.BupAction.Click += new System.EventHandler(this.BupAction_Click);
            // 
            // bLoad
            // 
            this.bLoad.Image = global::UCC.Properties.Resources.Load_icon;
            this.bLoad.Location = new System.Drawing.Point(17, 313);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(87, 34);
            this.bLoad.TabIndex = 3;
            this.bLoad.Text = "Load ...";
            this.bLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // editActionNav
            // 
            this.editActionNav.Controls.Add(this.generalActionPage);
            this.editActionNav.Controls.Add(this.kryptonPage7);
            this.editActionNav.Location = new System.Drawing.Point(268, 12);
            this.editActionNav.Name = "editActionNav";
            this.editActionNav.SelectedIndex = 1;
            this.editActionNav.Size = new System.Drawing.Size(467, 292);
            this.editActionNav.TabIndex = 2;
            this.editActionNav.Text = "kryptonNavigator3";
            // 
            // generalActionPage
            // 
            this.generalActionPage.Controls.Add(this.kryptonPanel4);
            this.generalActionPage.ImageIndex = 0;
            this.generalActionPage.Location = new System.Drawing.Point(4, 22);
            this.generalActionPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.generalActionPage.Name = "generalActionPage";
            this.generalActionPage.Size = new System.Drawing.Size(459, 266);
            this.generalActionPage.TabIndex = 0;
            this.generalActionPage.Text = "General";
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.propertyGrid1);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(459, 266);
            this.kryptonPanel4.TabIndex = 0;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(453, 260);
            this.propertyGrid1.TabIndex = 47;
            this.propertyGrid1.ToolbarVisible = false;
            this.propertyGrid1.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid1_PropertyValueChanged);
            // 
            // kryptonPage7
            // 
            this.kryptonPage7.Controls.Add(this.kryptonPanel3);
            this.kryptonPage7.ImageIndex = 1;
            this.kryptonPage7.Location = new System.Drawing.Point(4, 22);
            this.kryptonPage7.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage7.Name = "kryptonPage7";
            this.kryptonPage7.Size = new System.Drawing.Size(459, 266);
            this.kryptonPage7.TabIndex = 1;
            this.kryptonPage7.Text = "Conditions";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.conditionsList);
            this.kryptonPanel3.Controls.Add(this.propertyGrid2);
            this.kryptonPanel3.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(459, 266);
            this.kryptonPanel3.TabIndex = 0;
            // 
            // conditionsList
            // 
            this.conditionsList.Location = new System.Drawing.Point(3, 3);
            this.conditionsList.Name = "conditionsList";
            this.conditionsList.Size = new System.Drawing.Size(161, 196);
            this.conditionsList.TabIndex = 49;
            this.conditionsList.SelectedIndexChanged += new System.EventHandler(this.conditionsList_SelectedIndexChanged);
            // 
            // propertyGrid2
            // 
            this.propertyGrid2.Location = new System.Drawing.Point(170, 3);
            this.propertyGrid2.Name = "propertyGrid2";
            this.propertyGrid2.Size = new System.Drawing.Size(286, 196);
            this.propertyGrid2.TabIndex = 48;
            this.propertyGrid2.ToolbarVisible = false;
            this.propertyGrid2.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid2_PropertyValueChanged);
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Controls.Add(this.b_RemoveCond);
            this.kryptonGroupBox1.Controls.Add(this.b_AddCond);
            this.kryptonGroupBox1.Location = new System.Drawing.Point(6, 205);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            this.kryptonGroupBox1.Size = new System.Drawing.Size(450, 54);
            this.kryptonGroupBox1.TabIndex = 4;
            this.kryptonGroupBox1.TabStop = false;
            this.kryptonGroupBox1.Text = "Add/Remove";
            // 
            // b_RemoveCond
            // 
            this.b_RemoveCond.Location = new System.Drawing.Point(233, 19);
            this.b_RemoveCond.Name = "b_RemoveCond";
            this.b_RemoveCond.Size = new System.Drawing.Size(72, 24);
            this.b_RemoveCond.TabIndex = 12;
            this.b_RemoveCond.Text = "Remove";
            this.b_RemoveCond.Click += new System.EventHandler(this.b_RemoveCond_Click);
            // 
            // b_AddCond
            // 
            this.b_AddCond.Location = new System.Drawing.Point(118, 19);
            this.b_AddCond.Name = "b_AddCond";
            this.b_AddCond.Size = new System.Drawing.Size(72, 24);
            this.b_AddCond.TabIndex = 11;
            this.b_AddCond.Text = "Add";
            this.b_AddCond.Click += new System.EventHandler(this.b_AddCond_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 358);
            this.ControlBox = false;
            this.Controls.Add(this.kryptonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "UCC";
            this.Load += new System.EventHandler(this.UCC_Load);
            this.kryptonPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.editActionNav.ResumeLayout(false);
            this.generalActionPage.ResumeLayout(false);
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonPage7.ResumeLayout(false);
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.conditionsList)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel kryptonPanel;
        private System.Windows.Forms.TabControl editActionNav;
        private System.Windows.Forms.TabPage generalActionPage;
        private System.Windows.Forms.TabPage kryptonPage7;
        private System.Windows.Forms.Panel kryptonPanel3;
        private System.Windows.Forms.GroupBox kryptonGroupBox1;
        private System.Windows.Forms.Button b_RemoveCond;
        private System.Windows.Forms.Button b_AddCond;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.Panel kryptonPanel4;
        private System.Windows.Forms.Button BupAction;
        private System.Windows.Forms.Button BDownAction;
        private System.Windows.Forms.Button BRemoveAction;
        private System.Windows.Forms.Button BAddAction;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bCLose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewComboBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn signDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BWizard;
        private System.Windows.Forms.Button BCPAdd;
        private System.Windows.Forms.Button BCopy;
        private System.Windows.Forms.Button UCCAlgo;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rb_Patrol;
        private System.Windows.Forms.RadioButton rb_Pull;
        private System.Windows.Forms.RadioButton rb_Combat;
        private System.Windows.Forms.ListBox actionList;
        private DevExpress.XtraEditors.ListBoxControl conditionsList;
        private System.Windows.Forms.PropertyGrid propertyGrid2;
    }
}

