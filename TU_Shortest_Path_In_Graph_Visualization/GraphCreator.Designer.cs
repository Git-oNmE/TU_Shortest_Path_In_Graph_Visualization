﻿namespace TU_Shortest_Path_In_Graph_Visualization
{
    partial class GraphCreator
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
            this.Visualization = new System.Windows.Forms.Panel();
            this.AddNodeButton = new System.Windows.Forms.Button();
            this.AddLinkButton = new System.Windows.Forms.Button();
            this.RemoveNodeButton = new System.Windows.Forms.Button();
            this.RemoveLinkButton = new System.Windows.Forms.Button();
            this.EditLinkButton = new System.Windows.Forms.Button();
            this.LoadGraphButton = new System.Windows.Forms.Button();
            this.SaveGraphButton = new System.Windows.Forms.Button();
            this.SimulateAlgorithmButton = new System.Windows.Forms.Button();
            this.Node1NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Node2NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.WeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NodesLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Node1NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Node2NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Visualization
            // 
            this.Visualization.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Visualization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Visualization.Location = new System.Drawing.Point(12, 12);
            this.Visualization.Name = "Visualization";
            this.Visualization.Size = new System.Drawing.Size(1312, 457);
            this.Visualization.TabIndex = 0;
            // 
            // AddNodeButton
            // 
            this.AddNodeButton.Location = new System.Drawing.Point(12, 521);
            this.AddNodeButton.Name = "AddNodeButton";
            this.AddNodeButton.Size = new System.Drawing.Size(166, 59);
            this.AddNodeButton.TabIndex = 1;
            this.AddNodeButton.Text = "Add Node";
            this.AddNodeButton.UseVisualStyleBackColor = true;
            // 
            // AddLinkButton
            // 
            this.AddLinkButton.Location = new System.Drawing.Point(276, 521);
            this.AddLinkButton.Name = "AddLinkButton";
            this.AddLinkButton.Size = new System.Drawing.Size(166, 59);
            this.AddLinkButton.TabIndex = 2;
            this.AddLinkButton.Text = "Add Link";
            this.AddLinkButton.UseVisualStyleBackColor = true;
            // 
            // RemoveNodeButton
            // 
            this.RemoveNodeButton.Location = new System.Drawing.Point(12, 628);
            this.RemoveNodeButton.Name = "RemoveNodeButton";
            this.RemoveNodeButton.Size = new System.Drawing.Size(166, 59);
            this.RemoveNodeButton.TabIndex = 3;
            this.RemoveNodeButton.Text = "Remove Node";
            this.RemoveNodeButton.UseVisualStyleBackColor = true;
            // 
            // RemoveLinkButton
            // 
            this.RemoveLinkButton.Location = new System.Drawing.Point(276, 628);
            this.RemoveLinkButton.Name = "RemoveLinkButton";
            this.RemoveLinkButton.Size = new System.Drawing.Size(166, 59);
            this.RemoveLinkButton.TabIndex = 4;
            this.RemoveLinkButton.Text = "Remove Link";
            this.RemoveLinkButton.UseVisualStyleBackColor = true;
            // 
            // EditLinkButton
            // 
            this.EditLinkButton.Location = new System.Drawing.Point(482, 521);
            this.EditLinkButton.Name = "EditLinkButton";
            this.EditLinkButton.Size = new System.Drawing.Size(166, 59);
            this.EditLinkButton.TabIndex = 5;
            this.EditLinkButton.Text = "Edit Link";
            this.EditLinkButton.UseVisualStyleBackColor = true;
            // 
            // LoadGraphButton
            // 
            this.LoadGraphButton.Location = new System.Drawing.Point(1158, 628);
            this.LoadGraphButton.Name = "LoadGraphButton";
            this.LoadGraphButton.Size = new System.Drawing.Size(166, 59);
            this.LoadGraphButton.TabIndex = 6;
            this.LoadGraphButton.Text = "Load Graph";
            this.LoadGraphButton.UseVisualStyleBackColor = true;
            // 
            // SaveGraphButton
            // 
            this.SaveGraphButton.Location = new System.Drawing.Point(1158, 521);
            this.SaveGraphButton.Name = "SaveGraphButton";
            this.SaveGraphButton.Size = new System.Drawing.Size(166, 59);
            this.SaveGraphButton.TabIndex = 7;
            this.SaveGraphButton.Text = "Save Graph";
            this.SaveGraphButton.UseVisualStyleBackColor = true;
            // 
            // SimulateAlgorithmButton
            // 
            this.SimulateAlgorithmButton.Location = new System.Drawing.Point(834, 590);
            this.SimulateAlgorithmButton.Name = "SimulateAlgorithmButton";
            this.SimulateAlgorithmButton.Size = new System.Drawing.Size(166, 59);
            this.SimulateAlgorithmButton.TabIndex = 8;
            this.SimulateAlgorithmButton.Text = "Simulate Algorithm";
            this.SimulateAlgorithmButton.UseVisualStyleBackColor = true;
            // 
            // Node1NumericUpDown
            // 
            this.Node1NumericUpDown.Location = new System.Drawing.Point(587, 637);
            this.Node1NumericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Node1NumericUpDown.Name = "Node1NumericUpDown";
            this.Node1NumericUpDown.Size = new System.Drawing.Size(61, 22);
            this.Node1NumericUpDown.TabIndex = 9;
            // 
            // Node2NumericUpDown
            // 
            this.Node2NumericUpDown.Location = new System.Drawing.Point(587, 665);
            this.Node2NumericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Node2NumericUpDown.Name = "Node2NumericUpDown";
            this.Node2NumericUpDown.Size = new System.Drawing.Size(61, 22);
            this.Node2NumericUpDown.TabIndex = 10;
            // 
            // WeightNumericUpDown
            // 
            this.WeightNumericUpDown.Location = new System.Drawing.Point(482, 665);
            this.WeightNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.WeightNumericUpDown.Name = "WeightNumericUpDown";
            this.WeightNumericUpDown.Size = new System.Drawing.Size(99, 22);
            this.WeightNumericUpDown.TabIndex = 11;
            // 
            // NodesLabel
            // 
            this.NodesLabel.AutoSize = true;
            this.NodesLabel.Location = new System.Drawing.Point(584, 611);
            this.NodesLabel.Name = "NodesLabel";
            this.NodesLabel.Size = new System.Drawing.Size(49, 17);
            this.NodesLabel.TabIndex = 12;
            this.NodesLabel.Text = "Nodes";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(479, 639);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(52, 17);
            this.WeightLabel.TabIndex = 13;
            this.WeightLabel.Text = "Weight";
            // 
            // GraphCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 746);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.NodesLabel);
            this.Controls.Add(this.WeightNumericUpDown);
            this.Controls.Add(this.Node2NumericUpDown);
            this.Controls.Add(this.Node1NumericUpDown);
            this.Controls.Add(this.SimulateAlgorithmButton);
            this.Controls.Add(this.SaveGraphButton);
            this.Controls.Add(this.LoadGraphButton);
            this.Controls.Add(this.EditLinkButton);
            this.Controls.Add(this.RemoveLinkButton);
            this.Controls.Add(this.RemoveNodeButton);
            this.Controls.Add(this.AddLinkButton);
            this.Controls.Add(this.AddNodeButton);
            this.Controls.Add(this.Visualization);
            this.Name = "GraphCreator";
            this.Text = "Graph Creator";
            ((System.ComponentModel.ISupportInitialize)(this.Node1NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Node2NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Visualization;
        private System.Windows.Forms.Button AddNodeButton;
        private System.Windows.Forms.Button AddLinkButton;
        private System.Windows.Forms.Button RemoveNodeButton;
        private System.Windows.Forms.Button RemoveLinkButton;
        private System.Windows.Forms.Button EditLinkButton;
        private System.Windows.Forms.Button LoadGraphButton;
        private System.Windows.Forms.Button SaveGraphButton;
        private System.Windows.Forms.Button SimulateAlgorithmButton;
        private System.Windows.Forms.NumericUpDown Node1NumericUpDown;
        private System.Windows.Forms.NumericUpDown Node2NumericUpDown;
        private System.Windows.Forms.NumericUpDown WeightNumericUpDown;
        private System.Windows.Forms.Label NodesLabel;
        private System.Windows.Forms.Label WeightLabel;
    }
}

