namespace gainapp;

partial class Form1
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
        tableLayoutPanel1 = new TableLayoutPanel();
        formsPlot1 = new ScottPlot.FormsPlot();
        formsPlot2 = new ScottPlot.FormsPlot();
        panel1 = new Panel();
        numericUpDown1 = new NumericUpDown();
        label2 = new Label();
        button1 = new Button();
        label1 = new Label();
        trackBar1 = new TrackBar();
        tableLayoutPanel1.SuspendLayout();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(formsPlot1, 0, 0);
        tableLayoutPanel1.Controls.Add(formsPlot2, 0, 1);
        tableLayoutPanel1.Controls.Add(panel1, 0, 2);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
        tableLayoutPanel1.Size = new Size(1146, 932);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // formsPlot1
        // 
        formsPlot1.Dock = DockStyle.Fill;
        formsPlot1.Location = new Point(6, 5);
        formsPlot1.Margin = new Padding(6, 5, 6, 5);
        formsPlot1.Name = "formsPlot1";
        formsPlot1.Size = new Size(1134, 411);
        formsPlot1.TabIndex = 0;
        // 
        // formsPlot2
        // 
        formsPlot2.Dock = DockStyle.Fill;
        formsPlot2.Location = new Point(6, 426);
        formsPlot2.Margin = new Padding(6, 5, 6, 5);
        formsPlot2.Name = "formsPlot2";
        formsPlot2.Size = new Size(1134, 411);
        formsPlot2.TabIndex = 1;
        // 
        // panel1
        // 
        panel1.Controls.Add(numericUpDown1);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(button1);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(trackBar1);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(3, 845);
        panel1.Name = "panel1";
        panel1.Size = new Size(1140, 84);
        panel1.TabIndex = 2;
        // 
        // numericUpDown1
        // 
        numericUpDown1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        numericUpDown1.Location = new Point(910, 40);
        numericUpDown1.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new Size(82, 31);
        numericUpDown1.TabIndex = 4;
        numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        label2.AutoSize = true;
        label2.Location = new Point(910, 12);
        label2.Name = "label2";
        label2.Size = new Size(65, 25);
        label2.TabIndex = 3;
        label2.Text = "Curves";
        // 
        // button1
        // 
        button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        button1.Location = new Point(998, 12);
        button1.Name = "button1";
        button1.Size = new Size(133, 62);
        button1.TabIndex = 2;
        button1.Text = "Randomize";
        button1.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(9, 9);
        label1.Name = "label1";
        label1.Size = new Size(94, 25);
        label1.TabIndex = 1;
        label1.Text = "Alignment";
        // 
        // trackBar1
        // 
        trackBar1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        trackBar1.Location = new Point(3, 37);
        trackBar1.Maximum = 100;
        trackBar1.Name = "trackBar1";
        trackBar1.Size = new Size(901, 69);
        trackBar1.TabIndex = 0;
        trackBar1.Value = 90;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1146, 932);
        Controls.Add(tableLayoutPanel1);
        Name = "Form1";
        Text = "AP Gain Inspector";
        tableLayoutPanel1.ResumeLayout(false);
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private ScottPlot.FormsPlot formsPlot1;
    private ScottPlot.FormsPlot formsPlot2;
    private Panel panel1;
    private Label label1;
    private TrackBar trackBar1;
    private NumericUpDown numericUpDown1;
    private Label label2;
    private Button button1;
}
