namespace AnimalPlacement
{
    partial class TextView
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
            this.lbObjects = new System.Windows.Forms.ListBox();
            this.btnOpenAddObject = new System.Windows.Forms.Button();
            this.lblCenterOfMass = new System.Windows.Forms.Label();
            this.pnlAddObject = new System.Windows.Forms.Panel();
            this.gbSuit = new System.Windows.Forms.GroupBox();
            this.lbSuit = new System.Windows.Forms.ListBox();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.lbGender = new System.Windows.Forms.ListBox();
            this.numWeight = new System.Windows.Forms.NumericUpDown();
            this.numYpos = new System.Windows.Forms.NumericUpDown();
            this.gbBreed = new System.Windows.Forms.GroupBox();
            this.lbBreed = new System.Windows.Forms.ListBox();
            this.pnlObjectType = new System.Windows.Forms.Panel();
            this.rbHuman = new System.Windows.Forms.RadioButton();
            this.rbDog = new System.Windows.Forms.RadioButton();
            this.rbCat = new System.Windows.Forms.RadioButton();
            this.numXpos = new System.Windows.Forms.NumericUpDown();
            this.btnCancelAdding = new System.Windows.Forms.Button();
            this.btnAddObject = new System.Windows.Forms.Button();
            this.btnClearInput = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.numEditYpos = new System.Windows.Forms.NumericUpDown();
            this.gbEditSuit = new System.Windows.Forms.GroupBox();
            this.lbEditSuit = new System.Windows.Forms.ListBox();
            this.numEditXpos = new System.Windows.Forms.NumericUpDown();
            this.gbEditGender = new System.Windows.Forms.GroupBox();
            this.lbEditGender = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numEditWeight = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.gbEditBreed = new System.Windows.Forms.GroupBox();
            this.lbEditBreed = new System.Windows.Forms.ListBox();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.btnEditUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.pnlActionMain = new System.Windows.Forms.Panel();
            this.pnlAddObject.SuspendLayout();
            this.gbSuit.SuspendLayout();
            this.gbGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYpos)).BeginInit();
            this.gbBreed.SuspendLayout();
            this.pnlObjectType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numXpos)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEditYpos)).BeginInit();
            this.gbEditSuit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEditXpos)).BeginInit();
            this.gbEditGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEditWeight)).BeginInit();
            this.gbEditBreed.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.pnlActionMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbObjects
            // 
            this.lbObjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbObjects.FormattingEnabled = true;
            this.lbObjects.ItemHeight = 20;
            this.lbObjects.Location = new System.Drawing.Point(11, 13);
            this.lbObjects.Name = "lbObjects";
            this.lbObjects.Size = new System.Drawing.Size(444, 344);
            this.lbObjects.TabIndex = 2;
            this.lbObjects.SelectedIndexChanged += new System.EventHandler(this.lbObjects_SelectedIndexChanged);
            // 
            // btnOpenAddObject
            // 
            this.btnOpenAddObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenAddObject.Location = new System.Drawing.Point(312, 6);
            this.btnOpenAddObject.Name = "btnOpenAddObject";
            this.btnOpenAddObject.Size = new System.Drawing.Size(136, 32);
            this.btnOpenAddObject.TabIndex = 40;
            this.btnOpenAddObject.Text = "Add Object..";
            this.btnOpenAddObject.Click += new System.EventHandler(this.btnOpenAddObject_Click);
            // 
            // lblCenterOfMass
            // 
            this.lblCenterOfMass.AutoSize = true;
            this.lblCenterOfMass.BackColor = System.Drawing.Color.PowderBlue;
            this.lblCenterOfMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCenterOfMass.Location = new System.Drawing.Point(16, 402);
            this.lblCenterOfMass.Name = "lblCenterOfMass";
            this.lblCenterOfMass.Size = new System.Drawing.Size(0, 17);
            this.lblCenterOfMass.TabIndex = 41;
            // 
            // pnlAddObject
            // 
            this.pnlAddObject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddObject.Controls.Add(this.gbSuit);
            this.pnlAddObject.Controls.Add(this.gbGender);
            this.pnlAddObject.Controls.Add(this.numWeight);
            this.pnlAddObject.Controls.Add(this.numYpos);
            this.pnlAddObject.Controls.Add(this.gbBreed);
            this.pnlAddObject.Controls.Add(this.pnlObjectType);
            this.pnlAddObject.Controls.Add(this.numXpos);
            this.pnlAddObject.Controls.Add(this.btnCancelAdding);
            this.pnlAddObject.Controls.Add(this.btnAddObject);
            this.pnlAddObject.Controls.Add(this.btnClearInput);
            this.pnlAddObject.Controls.Add(this.label6);
            this.pnlAddObject.Controls.Add(this.label1);
            this.pnlAddObject.Controls.Add(this.label2);
            this.pnlAddObject.Controls.Add(this.label3);
            this.pnlAddObject.Location = new System.Drawing.Point(4, 61);
            this.pnlAddObject.Name = "pnlAddObject";
            this.pnlAddObject.Size = new System.Drawing.Size(457, 230);
            this.pnlAddObject.TabIndex = 42;
            this.pnlAddObject.Visible = false;
            // 
            // gbSuit
            // 
            this.gbSuit.Controls.Add(this.lbSuit);
            this.gbSuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbSuit.Location = new System.Drawing.Point(241, 9);
            this.gbSuit.Name = "gbSuit";
            this.gbSuit.Size = new System.Drawing.Size(151, 108);
            this.gbSuit.TabIndex = 48;
            this.gbSuit.TabStop = false;
            this.gbSuit.Text = "Suit";
            this.gbSuit.Visible = false;
            // 
            // lbSuit
            // 
            this.lbSuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSuit.FormattingEnabled = true;
            this.lbSuit.ItemHeight = 20;
            this.lbSuit.Location = new System.Drawing.Point(15, 27);
            this.lbSuit.Name = "lbSuit";
            this.lbSuit.Size = new System.Drawing.Size(120, 64);
            this.lbSuit.TabIndex = 50;
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.lbGender);
            this.gbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbGender.Location = new System.Drawing.Point(245, 9);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(151, 100);
            this.gbGender.TabIndex = 46;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            this.gbGender.Visible = false;
            // 
            // lbGender
            // 
            this.lbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGender.FormattingEnabled = true;
            this.lbGender.ItemHeight = 20;
            this.lbGender.Location = new System.Drawing.Point(10, 30);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(120, 44);
            this.lbGender.TabIndex = 0;
            // 
            // numWeight
            // 
            this.numWeight.Location = new System.Drawing.Point(145, 141);
            this.numWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWeight.Name = "numWeight";
            this.numWeight.Size = new System.Drawing.Size(67, 20);
            this.numWeight.TabIndex = 45;
            this.numWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numYpos
            // 
            this.numYpos.Location = new System.Drawing.Point(145, 66);
            this.numYpos.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numYpos.Name = "numYpos";
            this.numYpos.Size = new System.Drawing.Size(67, 20);
            this.numYpos.TabIndex = 44;
            // 
            // gbBreed
            // 
            this.gbBreed.Controls.Add(this.lbBreed);
            this.gbBreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbBreed.Location = new System.Drawing.Point(241, 16);
            this.gbBreed.Name = "gbBreed";
            this.gbBreed.Size = new System.Drawing.Size(151, 112);
            this.gbBreed.TabIndex = 47;
            this.gbBreed.TabStop = false;
            this.gbBreed.Text = "Breed";
            this.gbBreed.Visible = false;
            // 
            // lbBreed
            // 
            this.lbBreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBreed.FormattingEnabled = true;
            this.lbBreed.ItemHeight = 20;
            this.lbBreed.Location = new System.Drawing.Point(16, 30);
            this.lbBreed.Name = "lbBreed";
            this.lbBreed.Size = new System.Drawing.Size(120, 64);
            this.lbBreed.TabIndex = 49;
            // 
            // pnlObjectType
            // 
            this.pnlObjectType.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlObjectType.Controls.Add(this.rbHuman);
            this.pnlObjectType.Controls.Add(this.rbDog);
            this.pnlObjectType.Controls.Add(this.rbCat);
            this.pnlObjectType.Location = new System.Drawing.Point(0, 0);
            this.pnlObjectType.Name = "pnlObjectType";
            this.pnlObjectType.Size = new System.Drawing.Size(104, 229);
            this.pnlObjectType.TabIndex = 43;
            // 
            // rbHuman
            // 
            this.rbHuman.Checked = true;
            this.rbHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHuman.Location = new System.Drawing.Point(13, 68);
            this.rbHuman.Name = "rbHuman";
            this.rbHuman.Size = new System.Drawing.Size(86, 24);
            this.rbHuman.TabIndex = 21;
            this.rbHuman.TabStop = true;
            this.rbHuman.Text = "Human";
            this.rbHuman.CheckedChanged += new System.EventHandler(this.rbObjectType_Changed);
            // 
            // rbDog
            // 
            this.rbDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDog.Location = new System.Drawing.Point(13, 136);
            this.rbDog.Name = "rbDog";
            this.rbDog.Size = new System.Drawing.Size(76, 24);
            this.rbDog.TabIndex = 24;
            this.rbDog.Text = "Dog";
            this.rbDog.CheckedChanged += new System.EventHandler(this.rbObjectType_Changed);
            // 
            // rbCat
            // 
            this.rbCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCat.Location = new System.Drawing.Point(13, 102);
            this.rbCat.Name = "rbCat";
            this.rbCat.Size = new System.Drawing.Size(76, 24);
            this.rbCat.TabIndex = 22;
            this.rbCat.Text = "Cat";
            this.rbCat.CheckedChanged += new System.EventHandler(this.rbObjectType_Changed);
            // 
            // numXpos
            // 
            this.numXpos.Location = new System.Drawing.Point(145, 42);
            this.numXpos.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numXpos.Name = "numXpos";
            this.numXpos.Size = new System.Drawing.Size(67, 20);
            this.numXpos.TabIndex = 42;
            // 
            // btnCancelAdding
            // 
            this.btnCancelAdding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAdding.Location = new System.Drawing.Point(347, 186);
            this.btnCancelAdding.Name = "btnCancelAdding";
            this.btnCancelAdding.Size = new System.Drawing.Size(96, 32);
            this.btnCancelAdding.TabIndex = 41;
            this.btnCancelAdding.Text = "Cancel";
            this.btnCancelAdding.Click += new System.EventHandler(this.btnCancelAdding_Click_1);
            // 
            // btnAddObject
            // 
            this.btnAddObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddObject.Location = new System.Drawing.Point(245, 186);
            this.btnAddObject.Name = "btnAddObject";
            this.btnAddObject.Size = new System.Drawing.Size(99, 32);
            this.btnAddObject.TabIndex = 41;
            this.btnAddObject.Text = "Add";
            this.btnAddObject.Click += new System.EventHandler(this.btnAddObject_Click_1);
            // 
            // btnClearInput
            // 
            this.btnClearInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearInput.Location = new System.Drawing.Point(122, 186);
            this.btnClearInput.Name = "btnClearInput";
            this.btnClearInput.Size = new System.Drawing.Size(117, 32);
            this.btnClearInput.TabIndex = 40;
            this.btnClearInput.Text = "Clear Input";
            this.btnClearInput.Click += new System.EventHandler(this.btnClearInput_Click_1);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(115, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 35;
            this.label6.Text = "Weight, kg";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Position";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Y";
            // 
            // pnlEdit
            // 
            this.pnlEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEdit.Controls.Add(this.numEditYpos);
            this.pnlEdit.Controls.Add(this.gbEditSuit);
            this.pnlEdit.Controls.Add(this.numEditXpos);
            this.pnlEdit.Controls.Add(this.gbEditGender);
            this.pnlEdit.Controls.Add(this.label5);
            this.pnlEdit.Controls.Add(this.label7);
            this.pnlEdit.Controls.Add(this.numEditWeight);
            this.pnlEdit.Controls.Add(this.label8);
            this.pnlEdit.Controls.Add(this.gbEditBreed);
            this.pnlEdit.Controls.Add(this.btnEditCancel);
            this.pnlEdit.Controls.Add(this.btnEditUpdate);
            this.pnlEdit.Controls.Add(this.label4);
            this.pnlEdit.Location = new System.Drawing.Point(25, 209);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(415, 145);
            this.pnlEdit.TabIndex = 50;
            this.pnlEdit.Visible = false;
            // 
            // numEditYpos
            // 
            this.numEditYpos.Location = new System.Drawing.Point(52, 52);
            this.numEditYpos.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numEditYpos.Name = "numEditYpos";
            this.numEditYpos.Size = new System.Drawing.Size(67, 20);
            this.numEditYpos.TabIndex = 53;
            // 
            // gbEditSuit
            // 
            this.gbEditSuit.Controls.Add(this.lbEditSuit);
            this.gbEditSuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbEditSuit.Location = new System.Drawing.Point(138, 4);
            this.gbEditSuit.Name = "gbEditSuit";
            this.gbEditSuit.Size = new System.Drawing.Size(151, 100);
            this.gbEditSuit.TabIndex = 48;
            this.gbEditSuit.TabStop = false;
            this.gbEditSuit.Text = "Suit";
            this.gbEditSuit.Visible = false;
            // 
            // lbEditSuit
            // 
            this.lbEditSuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEditSuit.FormattingEnabled = true;
            this.lbEditSuit.ItemHeight = 20;
            this.lbEditSuit.Location = new System.Drawing.Point(15, 27);
            this.lbEditSuit.Name = "lbEditSuit";
            this.lbEditSuit.Size = new System.Drawing.Size(120, 64);
            this.lbEditSuit.TabIndex = 50;
            // 
            // numEditXpos
            // 
            this.numEditXpos.Location = new System.Drawing.Point(52, 28);
            this.numEditXpos.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numEditXpos.Name = "numEditXpos";
            this.numEditXpos.Size = new System.Drawing.Size(67, 20);
            this.numEditXpos.TabIndex = 52;
            // 
            // gbEditGender
            // 
            this.gbEditGender.Controls.Add(this.lbEditGender);
            this.gbEditGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbEditGender.Location = new System.Drawing.Point(135, 4);
            this.gbEditGender.Name = "gbEditGender";
            this.gbEditGender.Size = new System.Drawing.Size(151, 100);
            this.gbEditGender.TabIndex = 46;
            this.gbEditGender.TabStop = false;
            this.gbEditGender.Text = "Gender";
            this.gbEditGender.Visible = false;
            // 
            // lbEditGender
            // 
            this.lbEditGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEditGender.FormattingEnabled = true;
            this.lbEditGender.ItemHeight = 20;
            this.lbEditGender.Location = new System.Drawing.Point(10, 30);
            this.lbEditGender.Name = "lbEditGender";
            this.lbEditGender.Size = new System.Drawing.Size(120, 44);
            this.lbEditGender.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 49;
            this.label5.Text = "Position";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 24);
            this.label7.TabIndex = 50;
            this.label7.Text = "X";
            // 
            // numEditWeight
            // 
            this.numEditWeight.Location = new System.Drawing.Point(51, 116);
            this.numEditWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEditWeight.Name = "numEditWeight";
            this.numEditWeight.Size = new System.Drawing.Size(67, 20);
            this.numEditWeight.TabIndex = 45;
            this.numEditWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 24);
            this.label8.TabIndex = 51;
            this.label8.Text = "Y";
            // 
            // gbEditBreed
            // 
            this.gbEditBreed.Controls.Add(this.lbEditBreed);
            this.gbEditBreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbEditBreed.Location = new System.Drawing.Point(135, 6);
            this.gbEditBreed.Name = "gbEditBreed";
            this.gbEditBreed.Size = new System.Drawing.Size(151, 112);
            this.gbEditBreed.TabIndex = 47;
            this.gbEditBreed.TabStop = false;
            this.gbEditBreed.Text = "Breed";
            this.gbEditBreed.Visible = false;
            // 
            // lbEditBreed
            // 
            this.lbEditBreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEditBreed.FormattingEnabled = true;
            this.lbEditBreed.ItemHeight = 20;
            this.lbEditBreed.Location = new System.Drawing.Point(16, 30);
            this.lbEditBreed.Name = "lbEditBreed";
            this.lbEditBreed.Size = new System.Drawing.Size(120, 64);
            this.lbEditBreed.TabIndex = 49;
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCancel.Location = new System.Drawing.Point(301, 67);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(96, 32);
            this.btnEditCancel.TabIndex = 41;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
            // 
            // btnEditUpdate
            // 
            this.btnEditUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUpdate.Location = new System.Drawing.Point(300, 17);
            this.btnEditUpdate.Name = "btnEditUpdate";
            this.btnEditUpdate.Size = new System.Drawing.Size(99, 32);
            this.btnEditUpdate.TabIndex = 41;
            this.btnEditUpdate.Text = "Update";
            this.btnEditUpdate.Click += new System.EventHandler(this.btnEditUpdate_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "Weight, kg";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 32);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(92, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(72, 32);
            this.btnEdit.TabIndex = 53;
            this.btnEdit.Text = "Edit..";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.btnDelete);
            this.pnlActions.Controls.Add(this.btnEdit);
            this.pnlActions.Location = new System.Drawing.Point(5, 4);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(168, 35);
            this.pnlActions.TabIndex = 54;
            this.pnlActions.Visible = false;
            // 
            // pnlActionMain
            // 
            this.pnlActionMain.Controls.Add(this.pnlActions);
            this.pnlActionMain.Controls.Add(this.btnOpenAddObject);
            this.pnlActionMain.Location = new System.Drawing.Point(7, 359);
            this.pnlActionMain.Name = "pnlActionMain";
            this.pnlActionMain.Size = new System.Drawing.Size(456, 42);
            this.pnlActionMain.TabIndex = 55;
            // 
            // ViewForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 422);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlAddObject);
            this.Controls.Add(this.lblCenterOfMass);
            this.Controls.Add(this.lbObjects);
            this.Controls.Add(this.pnlActionMain);
            this.Location = new System.Drawing.Point(62, 0);
            this.Name = "ViewForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Text form";
            this.Load += new System.EventHandler(this.ViewForm1_Load);
            this.Move += new System.EventHandler(this.ViewForm1_Move);
            this.pnlAddObject.ResumeLayout(false);
            this.gbSuit.ResumeLayout(false);
            this.gbGender.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYpos)).EndInit();
            this.gbBreed.ResumeLayout(false);
            this.pnlObjectType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numXpos)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numEditYpos)).EndInit();
            this.gbEditSuit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numEditXpos)).EndInit();
            this.gbEditGender.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numEditWeight)).EndInit();
            this.gbEditBreed.ResumeLayout(false);
            this.pnlActions.ResumeLayout(false);
            this.pnlActionMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbObjects;
        private System.Windows.Forms.Button btnOpenAddObject;
        private System.Windows.Forms.Label lblCenterOfMass;
        private System.Windows.Forms.Panel pnlAddObject;
        private System.Windows.Forms.GroupBox gbSuit;
        private System.Windows.Forms.ListBox lbSuit;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.ListBox lbGender;
        private System.Windows.Forms.NumericUpDown numWeight;
        private System.Windows.Forms.NumericUpDown numYpos;
        private System.Windows.Forms.GroupBox gbBreed;
        private System.Windows.Forms.ListBox lbBreed;
        private System.Windows.Forms.Panel pnlObjectType;
        private System.Windows.Forms.RadioButton rbHuman;
        private System.Windows.Forms.RadioButton rbDog;
        private System.Windows.Forms.RadioButton rbCat;
        private System.Windows.Forms.NumericUpDown numXpos;
        private System.Windows.Forms.Button btnCancelAdding;
        private System.Windows.Forms.Button btnAddObject;
        private System.Windows.Forms.Button btnClearInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.NumericUpDown numEditYpos;
        private System.Windows.Forms.GroupBox gbEditSuit;
        private System.Windows.Forms.ListBox lbEditSuit;
        private System.Windows.Forms.NumericUpDown numEditXpos;
        private System.Windows.Forms.GroupBox gbEditGender;
        private System.Windows.Forms.ListBox lbEditGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numEditWeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbEditBreed;
        private System.Windows.Forms.ListBox lbEditBreed;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.Button btnEditUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Panel pnlActionMain;
    }
}