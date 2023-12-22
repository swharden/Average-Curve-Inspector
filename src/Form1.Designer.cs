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
        tableLayoutPanel2 = new TableLayoutPanel();
        panel4 = new Panel();
        button1 = new Button();
        numericUpDown1 = new NumericUpDown();
        label2 = new Label();
        panel3 = new Panel();
        label3 = new Label();
        tbVertical = new TrackBar();
        panel2 = new Panel();
        tbHorizontal = new TrackBar();
        label1 = new Label();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        panel4.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        panel3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)tbVertical).BeginInit();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)tbHorizontal).BeginInit();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(formsPlot1, 0, 0);
        tableLayoutPanel1.Controls.Add(formsPlot2, 0, 1);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Margin = new Padding(2);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 4;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
        tableLayoutPanel1.Size = new Size(802, 718);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // formsPlot1
        // 
        formsPlot1.Dock = DockStyle.Fill;
        formsPlot1.Location = new Point(4, 3);
        formsPlot1.Margin = new Padding(4, 3, 4, 3);
        formsPlot1.Name = "formsPlot1";
        formsPlot1.Size = new Size(794, 318);
        formsPlot1.TabIndex = 0;
        // 
        // formsPlot2
        // 
        formsPlot2.Dock = DockStyle.Fill;
        formsPlot2.Location = new Point(4, 327);
        formsPlot2.Margin = new Padding(4, 3, 4, 3);
        formsPlot2.Name = "formsPlot2";
        formsPlot2.Size = new Size(794, 318);
        formsPlot2.TabIndex = 1;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 3;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel2.Controls.Add(panel4, 2, 0);
        tableLayoutPanel2.Controls.Add(panel3, 1, 0);
        tableLayoutPanel2.Controls.Add(panel2, 0, 0);
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(3, 651);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.Size = new Size(796, 64);
        tableLayoutPanel2.TabIndex = 3;
        // 
        // panel4
        // 
        panel4.Controls.Add(button1);
        panel4.Controls.Add(numericUpDown1);
        panel4.Controls.Add(label2);
        panel4.Dock = DockStyle.Fill;
        panel4.Location = new Point(533, 3);
        panel4.Name = "panel4";
        panel4.Size = new Size(260, 58);
        panel4.TabIndex = 2;
        // 
        // button1
        // 
        button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        button1.Location = new Point(162, 3);
        button1.Margin = new Padding(2);
        button1.Name = "button1";
        button1.Size = new Size(93, 37);
        button1.TabIndex = 2;
        button1.Text = "Randomize";
        button1.UseVisualStyleBackColor = true;
        // 
        // numericUpDown1
        // 
        numericUpDown1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        numericUpDown1.Location = new Point(101, 17);
        numericUpDown1.Margin = new Padding(2);
        numericUpDown1.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new Size(57, 23);
        numericUpDown1.TabIndex = 4;
        numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        label2.AutoSize = true;
        label2.Location = new Point(101, -3);
        label2.Margin = new Padding(2, 0, 2, 0);
        label2.Name = "label2";
        label2.Size = new Size(43, 15);
        label2.TabIndex = 3;
        label2.Text = "Curves";
        // 
        // panel3
        // 
        panel3.Controls.Add(label3);
        panel3.Controls.Add(tbVertical);
        panel3.Dock = DockStyle.Fill;
        panel3.Location = new Point(268, 3);
        panel3.Name = "panel3";
        panel3.Size = new Size(259, 58);
        panel3.TabIndex = 1;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(2, 0);
        label3.Margin = new Padding(2, 0, 2, 0);
        label3.Name = "label3";
        label3.Size = new Size(94, 15);
        label3.TabIndex = 6;
        label3.Text = "Vertical Variation";
        // 
        // tbVertical
        // 
        tbVertical.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        tbVertical.Location = new Point(2, 17);
        tbVertical.Margin = new Padding(2);
        tbVertical.Maximum = 100;
        tbVertical.Name = "tbVertical";
        tbVertical.Size = new Size(255, 45);
        tbVertical.TabIndex = 5;
        tbVertical.Value = 30;
        // 
        // panel2
        // 
        panel2.Controls.Add(tbHorizontal);
        panel2.Controls.Add(label1);
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(3, 3);
        panel2.Name = "panel2";
        panel2.Size = new Size(259, 58);
        panel2.TabIndex = 0;
        // 
        // tbHorizontal
        // 
        tbHorizontal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        tbHorizontal.Location = new Point(5, 17);
        tbHorizontal.Margin = new Padding(2);
        tbHorizontal.Maximum = 100;
        tbHorizontal.Name = "tbHorizontal";
        tbHorizontal.Size = new Size(252, 45);
        tbHorizontal.TabIndex = 0;
        tbHorizontal.Value = 30;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(5, 0);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(111, 15);
        label1.TabIndex = 1;
        label1.Text = "Horizontal Variation";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(802, 718);
        Controls.Add(tableLayoutPanel1);
        Margin = new Padding(2);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Average Curve Inspector";
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        panel4.ResumeLayout(false);
        panel4.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)tbVertical).EndInit();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)tbHorizontal).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private ScottPlot.FormsPlot formsPlot1;
    private ScottPlot.FormsPlot formsPlot2;
    private Label label1;
    private TrackBar tbHorizontal;
    private NumericUpDown numericUpDown1;
    private Label label2;
    private Button button1;
    private Label label3;
    private TrackBar tbVertical;
    private TableLayoutPanel tableLayoutPanel2;
    private Panel panel4;
    private Panel panel3;
    private Panel panel2;
}
