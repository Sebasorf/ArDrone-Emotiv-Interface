namespace UI
{
    partial class MainProgram
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.forward_btn = new System.Windows.Forms.Button();
            this.right_btn = new System.Windows.Forms.Button();
            this.left_btn = new System.Windows.Forms.Button();
            this.backward_btn = new System.Windows.Forms.Button();
            this.up_btn = new System.Windows.Forms.Button();
            this.down_btn = new System.Windows.Forms.Button();
            this.ip_lbl = new System.Windows.Forms.Label();
            this.port_lbl = new System.Windows.Forms.Label();
            this.init_btn = new System.Windows.Forms.Button();
            this.ip_txt = new System.Windows.Forms.TextBox();
            this.port_txt = new System.Windows.Forms.TextBox();
            this.reset_btn = new System.Windows.Forms.Button();
            this.movements_grp = new System.Windows.Forms.GroupBox();
            this.height_grp = new System.Windows.Forms.GroupBox();
            this.t_left_btn = new System.Windows.Forms.Button();
            this.t_right_btn = new System.Windows.Forms.Button();
            this.takeoff_btn = new System.Windows.Forms.Button();
            this.land_btn = new System.Windows.Forms.Button();
            this.movements_grp.SuspendLayout();
            this.height_grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // forward_btn
            // 
            this.forward_btn.Enabled = false;
            this.forward_btn.Location = new System.Drawing.Point(100, 49);
            this.forward_btn.Name = "forward_btn";
            this.forward_btn.Size = new System.Drawing.Size(75, 23);
            this.forward_btn.TabIndex = 0;
            this.forward_btn.Text = "&Forward";
            this.forward_btn.UseVisualStyleBackColor = true;
            this.forward_btn.Click += new System.EventHandler(this.forward_btn_Click);
            this.forward_btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // right_btn
            // 
            this.right_btn.Enabled = false;
            this.right_btn.Location = new System.Drawing.Point(189, 87);
            this.right_btn.Name = "right_btn";
            this.right_btn.Size = new System.Drawing.Size(75, 23);
            this.right_btn.TabIndex = 1;
            this.right_btn.Text = "&Right";
            this.right_btn.UseVisualStyleBackColor = true;
            this.right_btn.Click += new System.EventHandler(this.right_btn_Click);
            this.right_btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // left_btn
            // 
            this.left_btn.Enabled = false;
            this.left_btn.Location = new System.Drawing.Point(13, 86);
            this.left_btn.Name = "left_btn";
            this.left_btn.Size = new System.Drawing.Size(75, 23);
            this.left_btn.TabIndex = 2;
            this.left_btn.Text = "&Left";
            this.left_btn.UseVisualStyleBackColor = true;
            this.left_btn.Click += new System.EventHandler(this.left_btn_Click);
            this.left_btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // backward_btn
            // 
            this.backward_btn.Enabled = false;
            this.backward_btn.Location = new System.Drawing.Point(100, 127);
            this.backward_btn.Name = "backward_btn";
            this.backward_btn.Size = new System.Drawing.Size(75, 23);
            this.backward_btn.TabIndex = 3;
            this.backward_btn.Text = "&Backward";
            this.backward_btn.UseVisualStyleBackColor = true;
            this.backward_btn.Click += new System.EventHandler(this.backward_btn_Click);
            this.backward_btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // up_btn
            // 
            this.up_btn.Enabled = false;
            this.up_btn.Location = new System.Drawing.Point(105, 49);
            this.up_btn.Name = "up_btn";
            this.up_btn.Size = new System.Drawing.Size(75, 23);
            this.up_btn.TabIndex = 4;
            this.up_btn.Text = "&Up";
            this.up_btn.UseVisualStyleBackColor = true;
            this.up_btn.Click += new System.EventHandler(this.up_btn_Click);
            this.up_btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // down_btn
            // 
            this.down_btn.Enabled = false;
            this.down_btn.Location = new System.Drawing.Point(105, 127);
            this.down_btn.Name = "down_btn";
            this.down_btn.Size = new System.Drawing.Size(75, 24);
            this.down_btn.TabIndex = 5;
            this.down_btn.Text = "&Down";
            this.down_btn.UseVisualStyleBackColor = true;
            this.down_btn.Click += new System.EventHandler(this.down_btn_Click);
            this.down_btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // ip_lbl
            // 
            this.ip_lbl.AutoSize = true;
            this.ip_lbl.Location = new System.Drawing.Point(154, 20);
            this.ip_lbl.Name = "ip_lbl";
            this.ip_lbl.Size = new System.Drawing.Size(17, 13);
            this.ip_lbl.TabIndex = 6;
            this.ip_lbl.Text = "IP";
            // 
            // port_lbl
            // 
            this.port_lbl.AutoSize = true;
            this.port_lbl.Location = new System.Drawing.Point(154, 54);
            this.port_lbl.Name = "port_lbl";
            this.port_lbl.Size = new System.Drawing.Size(26, 13);
            this.port_lbl.TabIndex = 7;
            this.port_lbl.Text = "Port";
            // 
            // init_btn
            // 
            this.init_btn.Location = new System.Drawing.Point(440, 33);
            this.init_btn.Name = "init_btn";
            this.init_btn.Size = new System.Drawing.Size(75, 23);
            this.init_btn.TabIndex = 8;
            this.init_btn.Text = "Initialize";
            this.init_btn.UseVisualStyleBackColor = true;
            this.init_btn.Click += new System.EventHandler(this.init_btn_Click);
            // 
            // ip_txt
            // 
            this.ip_txt.Location = new System.Drawing.Point(213, 20);
            this.ip_txt.Name = "ip_txt";
            this.ip_txt.Size = new System.Drawing.Size(158, 20);
            this.ip_txt.TabIndex = 9;
            // 
            // port_txt
            // 
            this.port_txt.Location = new System.Drawing.Point(213, 54);
            this.port_txt.Name = "port_txt";
            this.port_txt.Size = new System.Drawing.Size(158, 20);
            this.port_txt.TabIndex = 10;
            // 
            // reset_btn
            // 
            this.reset_btn.Enabled = false;
            this.reset_btn.Location = new System.Drawing.Point(270, 345);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(116, 29);
            this.reset_btn.TabIndex = 11;
            this.reset_btn.Text = "Reset Connection";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // movements_grp
            // 
            this.movements_grp.Controls.Add(this.backward_btn);
            this.movements_grp.Controls.Add(this.left_btn);
            this.movements_grp.Controls.Add(this.right_btn);
            this.movements_grp.Controls.Add(this.forward_btn);
            this.movements_grp.Location = new System.Drawing.Point(13, 83);
            this.movements_grp.Name = "movements_grp";
            this.movements_grp.Size = new System.Drawing.Size(291, 184);
            this.movements_grp.TabIndex = 12;
            this.movements_grp.TabStop = false;
            this.movements_grp.Text = "Movements";
            // 
            // height_grp
            // 
            this.height_grp.Controls.Add(this.t_left_btn);
            this.height_grp.Controls.Add(this.t_right_btn);
            this.height_grp.Controls.Add(this.up_btn);
            this.height_grp.Controls.Add(this.down_btn);
            this.height_grp.Location = new System.Drawing.Point(353, 83);
            this.height_grp.Name = "height_grp";
            this.height_grp.Size = new System.Drawing.Size(294, 183);
            this.height_grp.TabIndex = 13;
            this.height_grp.TabStop = false;
            this.height_grp.Text = "Height and Directions";
            // 
            // t_left_btn
            // 
            this.t_left_btn.Enabled = false;
            this.t_left_btn.Location = new System.Drawing.Point(16, 87);
            this.t_left_btn.Name = "t_left_btn";
            this.t_left_btn.Size = new System.Drawing.Size(75, 23);
            this.t_left_btn.TabIndex = 6;
            this.t_left_btn.Text = "Tur&n Left";
            this.t_left_btn.UseVisualStyleBackColor = true;
            this.t_left_btn.Click += new System.EventHandler(this.t_left_btn_Click);
            this.t_left_btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // t_right_btn
            // 
            this.t_right_btn.Enabled = false;
            this.t_right_btn.Location = new System.Drawing.Point(193, 87);
            this.t_right_btn.Name = "t_right_btn";
            this.t_right_btn.Size = new System.Drawing.Size(75, 23);
            this.t_right_btn.TabIndex = 4;
            this.t_right_btn.Text = "Turn Rig&ht";
            this.t_right_btn.UseVisualStyleBackColor = true;
            this.t_right_btn.Click += new System.EventHandler(this.t_right_btn_Click);
            this.t_right_btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // takeoff_btn
            // 
            this.takeoff_btn.Location = new System.Drawing.Point(113, 294);
            this.takeoff_btn.Name = "takeoff_btn";
            this.takeoff_btn.Size = new System.Drawing.Size(75, 23);
            this.takeoff_btn.TabIndex = 14;
            this.takeoff_btn.Text = "&Take off";
            this.takeoff_btn.UseVisualStyleBackColor = true;
            this.takeoff_btn.Click += new System.EventHandler(this.takeoff_btn_Click);
            this.takeoff_btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // land_btn
            // 
            this.land_btn.Location = new System.Drawing.Point(458, 294);
            this.land_btn.Name = "land_btn";
            this.land_btn.Size = new System.Drawing.Size(75, 23);
            this.land_btn.TabIndex = 15;
            this.land_btn.Text = "L&and";
            this.land_btn.UseVisualStyleBackColor = true;
            this.land_btn.Click += new System.EventHandler(this.land_btn_Click);
            this.land_btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // MainProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 397);
            this.Controls.Add(this.land_btn);
            this.Controls.Add(this.takeoff_btn);
            this.Controls.Add(this.height_grp);
            this.Controls.Add(this.movements_grp);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.port_txt);
            this.Controls.Add(this.ip_txt);
            this.Controls.Add(this.init_btn);
            this.Controls.Add(this.port_lbl);
            this.Controls.Add(this.ip_lbl);
            this.Name = "MainProgram";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.movements_grp.ResumeLayout(false);
            this.height_grp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button forward_btn;
        private System.Windows.Forms.Button right_btn;
        private System.Windows.Forms.Button left_btn;
        private System.Windows.Forms.Button backward_btn;
        private System.Windows.Forms.Button up_btn;
        private System.Windows.Forms.Button down_btn;
        private System.Windows.Forms.Label ip_lbl;
        private System.Windows.Forms.Label port_lbl;
        private System.Windows.Forms.Button init_btn;
        private System.Windows.Forms.TextBox ip_txt;
        private System.Windows.Forms.TextBox port_txt;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.GroupBox movements_grp;
        private System.Windows.Forms.GroupBox height_grp;
        private System.Windows.Forms.Button t_left_btn;
        private System.Windows.Forms.Button t_right_btn;
        private System.Windows.Forms.Button takeoff_btn;
        private System.Windows.Forms.Button land_btn;
    }
}

