procedure InitializeComponent;
    begin
        var resources: System.ComponentModel.ComponentResourceManager := new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        self.button1 := new System.Windows.Forms.Button();
        self.label1 := new System.Windows.Forms.Label();
        self.label2 := new System.Windows.Forms.Label();
        self.label3 := new System.Windows.Forms.Label();
        self.button2 := new System.Windows.Forms.Button();
        self.button3 := new System.Windows.Forms.Button();
        self.button4 := new System.Windows.Forms.Button();
        self.button5 := new System.Windows.Forms.Button();
        self.button6 := new System.Windows.Forms.Button();
        self.button7 := new System.Windows.Forms.Button();
        self.button8 := new System.Windows.Forms.Button();
        self.button9 := new System.Windows.Forms.Button();
        self.button10 := new System.Windows.Forms.Button();
        self.button12 := new System.Windows.Forms.Button();
        self.button13 := new System.Windows.Forms.Button();
        self.button14 := new System.Windows.Forms.Button();
        self.button11 := new System.Windows.Forms.Button();
        self.button16 := new System.Windows.Forms.Button();
        self.SuspendLayout();
        // 
        // button1
        // 
        self.button1.Font := new System.Drawing.Font('Microsoft Sans Serif', 13.8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (System.Byte(204)));
        self.button1.Location := new System.Drawing.Point(22, 158);
        self.button1.Name := 'button1';
        self.button1.Size := new System.Drawing.Size(73, 44);
        self.button1.TabIndex := 0;
        self.button1.Text := '1';
        self.button1.UseVisualStyleBackColor := true;
        self.button1.Click += button1_Click;
        // 
        // label1
        // 
        self.label1.BackColor := System.Drawing.SystemColors.ButtonHighlight;
        self.label1.Font := new System.Drawing.Font('Microsoft Sans Serif', 16.2, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (System.Byte(204)));
        self.label1.Location := new System.Drawing.Point(23, 95);
        self.label1.Name := 'label1';
        self.label1.Size := new System.Drawing.Size(181, 36);
        self.label1.TabIndex := 1;
        self.label1.TextAlign := System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        self.label2.BackColor := System.Drawing.Color.DarkCyan;
        self.label2.Font := new System.Drawing.Font('Microsoft Sans Serif', 16.2, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (System.Byte(204)));
        self.label2.Location := new System.Drawing.Point(208, 95);
        self.label2.Name := 'label2';
        self.label2.Size := new System.Drawing.Size(38, 36);
        self.label2.TabIndex := 2;
        self.label2.Text := '=';
        self.label2.TextAlign := System.Drawing.ContentAlignment.MiddleCenter;
        self.label2.Click += label2_Click;
        // 
        // label3
        // 
        self.label3.BackColor := System.Drawing.Color.DarkCyan;
        self.label3.Font := new System.Drawing.Font('Microsoft Sans Serif', 16.2, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (System.Byte(204)));
        self.label3.Location := new System.Drawing.Point(232, 95);
        self.label3.Name := 'label3';
        self.label3.Size := new System.Drawing.Size(188, 36);
        self.label3.TabIndex := 3;
        self.label3.TextAlign := System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // button2
        // 
        self.button2.Font := new System.Drawing.Font('Microsoft Sans Serif', 13.8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (System.Byte(204)));
        self.button2.Location := new System.Drawing.Point(101, 158);
        self.button2.Name := 'button2';
        self.button2.Size := new System.Drawing.Size(73, 44);
        self.button2.TabIndex := 4;
        self.button2.Text := '2';
        self.button2.UseVisualStyleBackColor := true;
        self.button2.Click += button2_Click;
        // 
        // button3
        // 
        self.button3.Font := new System.Drawing.Font('Microsoft Sans Serif', 13.8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (System.Byte(204)));
        self.button3.Location := new System.Drawing.Point(180, 158);
        self.button3.Name := 'button3';
        self.button3.Size := new System.Drawing.Size(73, 44);
        self.button3.TabIndex := 5;
        self.button3.Text := '3';
        self.button3.UseVisualStyleBackColor := true;
        self.button3.Click += button3_Click;
        // 
        // button4
        // 
        self.button4.Font := new System.Drawing.Font('Microsoft Sans Serif', 13.8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (System.Byte(204)));
        self.button4.Location := new System.Drawing.Point(22, 208);
        self.button4.Name := 'button4';
        self.button4.Size := new System.Drawing.Size(73, 44);
        self.button4.TabIndex := 6;
        self.button4.Text := '4';
        self.button4.UseVisualStyleBackColor := true;
        self.button4.Click += button4_Click;
        // 
        // button5
        // 
        self.button5.Font := new System.Drawing.Font('Microsoft Sans Serif', 13.8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (System.Byte(204)));
        self.button5.Location := new System.Drawing.Point(101, 208);
        self.button5.Name := 'button5';
        self.button5.Size := new System.Drawing.Size(73, 44);
        self.button5.TabIndex := 7;
        self.button5.Text := '5';
        self.button5.UseVisualStyleBackColor := true;
        self.button5.Click += button5_Click;
        // 
        // button6
        // 
        self.button6.Font := new System.Drawing.Font('Microsoft Sans Serif', 13.8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (System.Byte(204)));
        self.button6.Location := new System.Drawing.Point(180, 208);
        self.button6.Name := 'button6';
        self.button6.Size := new System.Drawing.Size(73, 44);
        self.button6.TabIndex := 8;
        self.button6.Text := '6';
        self.button6.UseVisualStyleBackColor := true;
        self.button6.Click += button6_Click;
        // 
        // button7
        // 
        self.button7.Font := new System.Drawing.Font('Microsoft Sans Serif', 13.8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (System.Byte(204)));
        self.button7.Location := new System.Drawing.Point(22, 258);
        self.button7.Name := 'button7';
        self.button7.Size := new System.Drawing.Size(73, 44);
        self.button7.TabIndex := 9;
        self.button7.Text := '7';
        self.button7.UseVisualStyleBackColor := true;
        self.button7.Click += button7_Click;
        // 
        // button8
        // 
        self.button8.Font := new System.Drawing.Font('Microsoft Sans Serif', 13.8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (System.Byte(204)));
        self.button8.Location := new System.Drawing.Point(101, 258);
        self.button8.Name := 'button8';
        self.button8.Size := new System.Drawing.Size(73, 44);
        self.button8.TabIndex := 10;
        self.button8.Text := '8';
        self.button8.UseVisualStyleBackColor := true;
        self.button8.Click += button8_Click;
        // 
        // button9
        // 
        self.button9.Font := new System.Drawing.Font('Microsoft Sans Serif', 13.8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (System.Byte(204)));
        self.button9.Location := new System.Drawing.Point(180, 258);
        self.button9.Name := 'button9';
        self.button9.Size := new System.Drawing.Size(73, 44);
        self.button9.TabIndex := 11;
        self.button9.Text := '9';
        self.button9.UseVisualStyleBackColor := true;
        self.button9.Click += button9_Click;
        // 
        // button10
        // 
        self.button10.Font := new System.Drawing.Font('Microsoft Sans Serif', 13.8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (System.Byte(204)));
        self.button10.Location := new System.Drawing.Point(101, 308);
        self.button10.Name := 'button10';
        self.button10.Size := new System.Drawing.Size(73, 44);
        self.button10.TabIndex := 12;
        self.button10.Text := '0';
        self.button10.UseVisualStyleBackColor := true;
        self.button10.Click += button10_Click;
        // 
        // button12
        // 
        self.button12.Font := new System.Drawing.Font('Microsoft Sans Serif', 13.8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (System.Byte(204)));
        self.button12.Location := new System.Drawing.Point(346, 208);
        self.button12.Name := 'button12';
        self.button12.Size := new System.Drawing.Size(73, 44);
        self.button12.TabIndex := 14;
        self.button12.Text := '-';
        self.button12.UseVisualStyleBackColor := true;
        self.button12.Click += button12_Click;
        // 
        // button13
        // 
        self.button13.Font := new System.Drawing.Font('Microsoft Sans Serif', 13.8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (System.Byte(204)));
        self.button13.Location := new System.Drawing.Point(346, 258);
        self.button13.Name := 'button13';
        self.button13.Size := new System.Drawing.Size(73, 44);
        self.button13.TabIndex := 15;
        self.button13.Text := '/';
        self.button13.UseVisualStyleBackColor := true;
        self.button13.Click += button13_Click;
        // 
        // button14
        // 
        self.button14.Font := new System.Drawing.Font('Microsoft Sans Serif', 13.8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (System.Byte(204)));
        self.button14.Location := new System.Drawing.Point(346, 308);
        self.button14.Name := 'button14';
        self.button14.Size := new System.Drawing.Size(73, 44);
        self.button14.TabIndex := 16;
        self.button14.Text := '*';
        self.button14.UseVisualStyleBackColor := true;
        self.button14.Click += button14_Click;
        // 
        // button11
        // 
        self.button11.Font := new System.Drawing.Font('Microsoft Sans Serif', 13.8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (System.Byte(204)));
        self.button11.Location := new System.Drawing.Point(346, 158);
        self.button11.Name := 'button11';
        self.button11.Size := new System.Drawing.Size(73, 44);
        self.button11.TabIndex := 13;
        self.button11.Text := '+';
        self.button11.UseVisualStyleBackColor := true;
        self.button11.Click += button11_Click;
        // 
        // button16
        // 
        self.button16.Font := new System.Drawing.Font('Microsoft Sans Serif', 19.8000011, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (System.Byte(204)));
        self.button16.Location := new System.Drawing.Point(222, 372);
        self.button16.Name := 'button16';
        self.button16.Size := new System.Drawing.Size(197, 106);
        self.button16.TabIndex := 18;
        self.button16.Text := '=';
        self.button16.UseVisualStyleBackColor := true;
        self.button16.Click += button16_Click;
        // 
        // Form1
        // 
        self.AutoScaleMode := System.Windows.Forms.AutoScaleMode.Inherit;
        self.BackColor := System.Drawing.Color.DarkCyan;
        self.ClientSize := new System.Drawing.Size(432, 497);
        self.Controls.Add(self.button16);
        self.Controls.Add(self.button14);
        self.Controls.Add(self.button13);
        self.Controls.Add(self.button12);
        self.Controls.Add(self.button11);
        self.Controls.Add(self.button10);
        self.Controls.Add(self.button9);
        self.Controls.Add(self.button8);
        self.Controls.Add(self.button7);
        self.Controls.Add(self.button6);
        self.Controls.Add(self.button5);
        self.Controls.Add(self.button4);
        self.Controls.Add(self.button3);
        self.Controls.Add(self.button2);
        self.Controls.Add(self.label3);
        self.Controls.Add(self.label2);
        self.Controls.Add(self.label1);
        self.Controls.Add(self.button1);
        self.Icon := (System.Drawing.Icon(resources.GetObject('$this.Icon')));
        self.MaximizeBox := false;
        self.Name := 'Form1';
        self.StartPosition := System.Windows.Forms.FormStartPosition.CenterScreen;
        self.Text := 'Калькулятор';
        self.ResumeLayout(false);
    end;
