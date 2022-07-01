namespace ProcessSchedulerProyect
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.Panel_Left = new System.Windows.Forms.Panel();
            this.Button_ReadyProcesses = new System.Windows.Forms.Button();
            this.PanelSmall_03 = new System.Windows.Forms.Panel();
            this.Button_ProcessPool = new System.Windows.Forms.Button();
            this.PanelSmall_02 = new System.Windows.Forms.Panel();
            this.Button_CreateNewProcess = new System.Windows.Forms.Button();
            this.PanelSmall_01 = new System.Windows.Forms.Panel();
            this.Label_01 = new System.Windows.Forms.Label();
            this.Icon_Minimize = new System.Windows.Forms.PictureBox();
            this.Button_Close = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.Panel_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Close)).BeginInit();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Left
            // 
            this.Panel_Left.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Left.BackgroundImage = global::ProcessSchedulerProyect.Properties.Resources.Panel02;
            this.Panel_Left.Controls.Add(this.Button_ReadyProcesses);
            this.Panel_Left.Controls.Add(this.PanelSmall_03);
            this.Panel_Left.Controls.Add(this.Button_ProcessPool);
            this.Panel_Left.Controls.Add(this.PanelSmall_02);
            this.Panel_Left.Controls.Add(this.Button_CreateNewProcess);
            this.Panel_Left.Controls.Add(this.PanelSmall_01);
            this.Panel_Left.Controls.Add(this.Label_01);
            this.Panel_Left.Location = new System.Drawing.Point(-1, 0);
            this.Panel_Left.Name = "Panel_Left";
            this.Panel_Left.Size = new System.Drawing.Size(279, 682);
            this.Panel_Left.TabIndex = 1;
            // 
            // Button_ReadyProcesses
            // 
            this.Button_ReadyProcesses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ReadyProcesses.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ReadyProcesses.ForeColor = System.Drawing.Color.Wheat;
            this.Button_ReadyProcesses.Image = global::ProcessSchedulerProyect.Properties.Resources.proccess_icon_Cde_icon;
            this.Button_ReadyProcesses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_ReadyProcesses.Location = new System.Drawing.Point(19, 199);
            this.Button_ReadyProcesses.Name = "Button_ReadyProcesses";
            this.Button_ReadyProcesses.Size = new System.Drawing.Size(238, 50);
            this.Button_ReadyProcesses.TabIndex = 10;
            this.Button_ReadyProcesses.Text = "Scheduler Executer";
            this.Button_ReadyProcesses.UseVisualStyleBackColor = true;
            this.Button_ReadyProcesses.Click += new System.EventHandler(this.Button_ReadyProcesses_Click);
            this.Button_ReadyProcesses.MouseCaptureChanged += new System.EventHandler(this.Button_ReadyProcesses_MouseCaptureChanged);
            // 
            // PanelSmall_03
            // 
            this.PanelSmall_03.BackColor = System.Drawing.Color.Wheat;
            this.PanelSmall_03.Location = new System.Drawing.Point(3, 199);
            this.PanelSmall_03.Name = "PanelSmall_03";
            this.PanelSmall_03.Size = new System.Drawing.Size(10, 50);
            this.PanelSmall_03.TabIndex = 9;
            // 
            // Button_ProcessPool
            // 
            this.Button_ProcessPool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ProcessPool.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ProcessPool.ForeColor = System.Drawing.Color.Wheat;
            this.Button_ProcessPool.Image = global::ProcessSchedulerProyect.Properties.Resources.proccess_icon_Cde_icon;
            this.Button_ProcessPool.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_ProcessPool.Location = new System.Drawing.Point(19, 133);
            this.Button_ProcessPool.Name = "Button_ProcessPool";
            this.Button_ProcessPool.Size = new System.Drawing.Size(238, 50);
            this.Button_ProcessPool.TabIndex = 8;
            this.Button_ProcessPool.Text = "Process Pool";
            this.Button_ProcessPool.UseVisualStyleBackColor = true;
            this.Button_ProcessPool.Click += new System.EventHandler(this.Button_ProcessPool_Click);
            this.Button_ProcessPool.MouseCaptureChanged += new System.EventHandler(this.Button_ProcessPool_MouseCaptureChanged);
            // 
            // PanelSmall_02
            // 
            this.PanelSmall_02.BackColor = System.Drawing.Color.Wheat;
            this.PanelSmall_02.Location = new System.Drawing.Point(3, 133);
            this.PanelSmall_02.Name = "PanelSmall_02";
            this.PanelSmall_02.Size = new System.Drawing.Size(10, 50);
            this.PanelSmall_02.TabIndex = 7;
            // 
            // Button_CreateNewProcess
            // 
            this.Button_CreateNewProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_CreateNewProcess.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_CreateNewProcess.ForeColor = System.Drawing.Color.Wheat;
            this.Button_CreateNewProcess.Image = global::ProcessSchedulerProyect.Properties.Resources.proccess_icon_Cde_icon;
            this.Button_CreateNewProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_CreateNewProcess.Location = new System.Drawing.Point(19, 68);
            this.Button_CreateNewProcess.Name = "Button_CreateNewProcess";
            this.Button_CreateNewProcess.Size = new System.Drawing.Size(238, 50);
            this.Button_CreateNewProcess.TabIndex = 6;
            this.Button_CreateNewProcess.Text = "Create New Process";
            this.Button_CreateNewProcess.UseVisualStyleBackColor = true;
            this.Button_CreateNewProcess.Click += new System.EventHandler(this.Button_CreateNewProcess_Click);
            this.Button_CreateNewProcess.MouseCaptureChanged += new System.EventHandler(this.Button_CreateNewProcess_MouseCaptureChanged);
            // 
            // PanelSmall_01
            // 
            this.PanelSmall_01.BackColor = System.Drawing.Color.Wheat;
            this.PanelSmall_01.Location = new System.Drawing.Point(3, 68);
            this.PanelSmall_01.Name = "PanelSmall_01";
            this.PanelSmall_01.Size = new System.Drawing.Size(10, 50);
            this.PanelSmall_01.TabIndex = 5;
            // 
            // Label_01
            // 
            this.Label_01.AutoSize = true;
            this.Label_01.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_01.ForeColor = System.Drawing.Color.Azure;
            this.Label_01.Location = new System.Drawing.Point(42, 18);
            this.Label_01.Name = "Label_01";
            this.Label_01.Size = new System.Drawing.Size(173, 19);
            this.Label_01.TabIndex = 4;
            this.Label_01.Text = "Process Scheduler";
            // 
            // Icon_Minimize
            // 
            this.Icon_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Icon_Minimize.Image = global::ProcessSchedulerProyect.Properties.Resources.icon_minimizar;
            this.Icon_Minimize.Location = new System.Drawing.Point(786, 12);
            this.Icon_Minimize.Name = "Icon_Minimize";
            this.Icon_Minimize.Size = new System.Drawing.Size(25, 25);
            this.Icon_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon_Minimize.TabIndex = 3;
            this.Icon_Minimize.TabStop = false;
            this.Icon_Minimize.Click += new System.EventHandler(this.Icon_Minimize_Click);
            // 
            // Button_Close
            // 
            this.Button_Close.BackColor = System.Drawing.Color.Transparent;
            this.Button_Close.Image = global::ProcessSchedulerProyect.Properties.Resources.icon_cerrar2;
            this.Button_Close.Location = new System.Drawing.Point(817, 12);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(25, 25);
            this.Button_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_Close.TabIndex = 2;
            this.Button_Close.TabStop = false;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Transparent;
            this.panelContenedor.Location = new System.Drawing.Point(278, 47);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(867, 655);
            this.panelContenedor.TabIndex = 4;
            this.panelContenedor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelContenedor_MouseDown);
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.Transparent;
            this.PanelTop.Controls.Add(this.Button_Close);
            this.PanelTop.Controls.Add(this.Icon_Minimize);
            this.PanelTop.Location = new System.Drawing.Point(278, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(867, 47);
            this.PanelTop.TabIndex = 4;
            this.PanelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseDown);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = global::ProcessSchedulerProyect.Properties.Resources.Venado01;
            this.ClientSize = new System.Drawing.Size(1144, 682);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.Panel_Left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process Scheduler";
            this.Panel_Left.ResumeLayout(false);
            this.Panel_Left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Close)).EndInit();
            this.PanelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel_Left;
        private System.Windows.Forms.PictureBox Icon_Minimize;
        private System.Windows.Forms.PictureBox Button_Close;
        private System.Windows.Forms.Button Button_CreateNewProcess;
        private System.Windows.Forms.Panel PanelSmall_01;
        private System.Windows.Forms.Label Label_01;
        private System.Windows.Forms.Button Button_ProcessPool;
        private System.Windows.Forms.Panel PanelSmall_02;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Button Button_ReadyProcesses;
        private System.Windows.Forms.Panel PanelSmall_03;
    }
}

