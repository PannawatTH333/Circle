namespace Circle
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHexahonWidth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCircleArea = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTriangleArea = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHexagonArea = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(69, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "รัศมี";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(127, 33);
            this.txtRadius.Multiline = true;
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(130, 32);
            this.txtRadius.TabIndex = 1;
            this.txtRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRadius.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(35, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "ความยาวฐาน";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(20, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "ความยาวฐาน";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(64, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "ความสูง";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(127, 98);
            this.txtHeight.Multiline = true;
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(130, 32);
            this.txtHeight.TabIndex = 5;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(127, 29);
            this.txtWidth.Multiline = true;
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(130, 32);
            this.txtWidth.TabIndex = 6;
            // 
            // txtHexahonWidth
            // 
            this.txtHexahonWidth.Location = new System.Drawing.Point(127, 52);
            this.txtHexahonWidth.Multiline = true;
            this.txtHexahonWidth.Name = "txtHexahonWidth";
            this.txtHexahonWidth.Size = new System.Drawing.Size(130, 32);
            this.txtHexahonWidth.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(540, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(590, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 18);
            this.label6.TabIndex = 9;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Silver;
            this.lblResult.Location = new System.Drawing.Point(522, 144);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(251, 147);
            this.lblResult.TabIndex = 10;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.BurlyWood;
            this.groupBox1.Controls.Add(this.btnCircleArea);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRadius);
            this.groupBox1.Location = new System.Drawing.Point(35, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 118);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "คำนวณพื้นที่วงกลม";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCircleArea
            // 
            this.btnCircleArea.Location = new System.Drawing.Point(309, 60);
            this.btnCircleArea.Name = "btnCircleArea";
            this.btnCircleArea.Size = new System.Drawing.Size(77, 42);
            this.btnCircleArea.TabIndex = 2;
            this.btnCircleArea.Text = "คำนวณ";
            this.btnCircleArea.UseVisualStyleBackColor = true;
            this.btnCircleArea.Click += new System.EventHandler(this.btnCircleArea_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGreen;
            this.groupBox2.Controls.Add(this.btnTriangleArea);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtHeight);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtWidth);
            this.groupBox2.Location = new System.Drawing.Point(35, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 147);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "คำนวณพื้นที่สามเหลี่ยม";
            // 
            // btnTriangleArea
            // 
            this.btnTriangleArea.Location = new System.Drawing.Point(309, 88);
            this.btnTriangleArea.Name = "btnTriangleArea";
            this.btnTriangleArea.Size = new System.Drawing.Size(77, 39);
            this.btnTriangleArea.TabIndex = 3;
            this.btnTriangleArea.Text = "คำนวณ";
            this.btnTriangleArea.UseVisualStyleBackColor = true;
            this.btnTriangleArea.Click += new System.EventHandler(this.btnTriangleArea_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Khaki;
            this.groupBox3.Controls.Add(this.btnHexagonArea);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtHexahonWidth);
            this.groupBox3.Location = new System.Drawing.Point(35, 297);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(433, 141);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "คำนวณพื้นที่หกเหลี่ยม";
            // 
            // btnHexagonArea
            // 
            this.btnHexagonArea.Location = new System.Drawing.Point(309, 84);
            this.btnHexagonArea.Name = "btnHexagonArea";
            this.btnHexagonArea.Size = new System.Drawing.Size(77, 39);
            this.btnHexagonArea.TabIndex = 7;
            this.btnHexagonArea.Text = "คำนวณ";
            this.btnHexagonArea.UseVisualStyleBackColor = true;
            this.btnHexagonArea.Click += new System.EventHandler(this.btnHexagonArea_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(570, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "พื้นที่ (ตารางหน่วย)";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "ลบ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label6);
            this.Name = "Form1";
            this.Text = "Circle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHexahonWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCircleArea;
        private System.Windows.Forms.Button btnTriangleArea;
        private System.Windows.Forms.Button btnHexagonArea;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

