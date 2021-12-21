
namespace Week5_TaskB_SocialNetwork
{
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
            this.label1 = new System.Windows.Forms.Label();
            this.ContainsGraphID = new System.Windows.Forms.Button();
            this.displayGraphList = new System.Windows.Forms.Label();
            this.PersonLabel = new System.Windows.Forms.Label();
            this.InsertBox = new System.Windows.Forms.TextBox();
            this.TotalNodes = new System.Windows.Forms.Button();
            this.AdjNode = new System.Windows.Forms.Button();
            this.InsertDirectedEdge = new System.Windows.Forms.Button();
            this.RemoveNode = new System.Windows.Forms.Button();
            this.InsertNode = new System.Windows.Forms.Button();
            this.nodeBID = new System.Windows.Forms.Label();
            this.nodeAID = new System.Windows.Forms.Label();
            this.personABox = new System.Windows.Forms.TextBox();
            this.personBBox = new System.Windows.Forms.TextBox();
            this.showConnected = new System.Windows.Forms.Button();
            this.AllConnectedPeople = new System.Windows.Forms.Label();
            this.AllConnectedToPerson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Social Network";
            // 
            // ContainsGraphID
            // 
            this.ContainsGraphID.Location = new System.Drawing.Point(205, 145);
            this.ContainsGraphID.Name = "ContainsGraphID";
            this.ContainsGraphID.Size = new System.Drawing.Size(117, 23);
            this.ContainsGraphID.TabIndex = 28;
            this.ContainsGraphID.Text = "Contains Person";
            this.ContainsGraphID.UseVisualStyleBackColor = true;
            this.ContainsGraphID.Click += new System.EventHandler(this.ContainsGraphID_Click);
            // 
            // displayGraphList
            // 
            this.displayGraphList.AutoSize = true;
            this.displayGraphList.Location = new System.Drawing.Point(540, 102);
            this.displayGraphList.Name = "displayGraphList";
            this.displayGraphList.Size = new System.Drawing.Size(126, 15);
            this.displayGraphList.TabIndex = 27;
            this.displayGraphList.Text = "Display Graph Content";
            // 
            // PersonLabel
            // 
            this.PersonLabel.AutoSize = true;
            this.PersonLabel.Location = new System.Drawing.Point(12, 84);
            this.PersonLabel.Name = "PersonLabel";
            this.PersonLabel.Size = new System.Drawing.Size(43, 15);
            this.PersonLabel.TabIndex = 26;
            this.PersonLabel.Text = "Person";
            // 
            // InsertBox
            // 
            this.InsertBox.Location = new System.Drawing.Point(12, 105);
            this.InsertBox.Name = "InsertBox";
            this.InsertBox.Size = new System.Drawing.Size(170, 23);
            this.InsertBox.TabIndex = 25;
            this.InsertBox.TextChanged += new System.EventHandler(this.InsertBox_TextChanged);
            // 
            // TotalNodes
            // 
            this.TotalNodes.Location = new System.Drawing.Point(328, 104);
            this.TotalNodes.Name = "TotalNodes";
            this.TotalNodes.Size = new System.Drawing.Size(98, 23);
            this.TotalNodes.TabIndex = 24;
            this.TotalNodes.Text = "Total People";
            this.TotalNodes.UseVisualStyleBackColor = true;
            this.TotalNodes.Click += new System.EventHandler(this.TotalNodes_Click);
            // 
            // AdjNode
            // 
            this.AdjNode.Location = new System.Drawing.Point(206, 218);
            this.AdjNode.Name = "AdjNode";
            this.AdjNode.Size = new System.Drawing.Size(116, 23);
            this.AdjNode.TabIndex = 23;
            this.AdjNode.Text = "Adjacent To Person";
            this.AdjNode.UseVisualStyleBackColor = true;
            this.AdjNode.Click += new System.EventHandler(this.AdjNode_Click);
            // 
            // InsertDirectedEdge
            // 
            this.InsertDirectedEdge.Location = new System.Drawing.Point(328, 217);
            this.InsertDirectedEdge.Name = "InsertDirectedEdge";
            this.InsertDirectedEdge.Size = new System.Drawing.Size(135, 23);
            this.InsertDirectedEdge.TabIndex = 22;
            this.InsertDirectedEdge.Text = "Insert Directed Edge";
            this.InsertDirectedEdge.UseVisualStyleBackColor = true;
            this.InsertDirectedEdge.Click += new System.EventHandler(this.InsertDirectedEdge_Click);
            // 
            // RemoveNode
            // 
            this.RemoveNode.Location = new System.Drawing.Point(328, 145);
            this.RemoveNode.Name = "RemoveNode";
            this.RemoveNode.Size = new System.Drawing.Size(98, 23);
            this.RemoveNode.TabIndex = 21;
            this.RemoveNode.Text = "Remove Person";
            this.RemoveNode.UseVisualStyleBackColor = true;
            this.RemoveNode.Click += new System.EventHandler(this.RemoveNode_Click);
            // 
            // InsertNode
            // 
            this.InsertNode.Location = new System.Drawing.Point(206, 104);
            this.InsertNode.Name = "InsertNode";
            this.InsertNode.Size = new System.Drawing.Size(116, 23);
            this.InsertNode.TabIndex = 20;
            this.InsertNode.Text = "Insert Person";
            this.InsertNode.UseVisualStyleBackColor = true;
            this.InsertNode.Click += new System.EventHandler(this.InsertNode_Click);
            // 
            // nodeBID
            // 
            this.nodeBID.AutoSize = true;
            this.nodeBID.Location = new System.Drawing.Point(12, 260);
            this.nodeBID.Name = "nodeBID";
            this.nodeBID.Size = new System.Drawing.Size(88, 15);
            this.nodeBID.TabIndex = 19;
            this.nodeBID.Text = "Person B Name";
            // 
            // nodeAID
            // 
            this.nodeAID.AutoSize = true;
            this.nodeAID.Location = new System.Drawing.Point(12, 200);
            this.nodeAID.Name = "nodeAID";
            this.nodeAID.Size = new System.Drawing.Size(89, 15);
            this.nodeAID.TabIndex = 18;
            this.nodeAID.Text = "Person A Name";
            // 
            // personABox
            // 
            this.personABox.Location = new System.Drawing.Point(12, 218);
            this.personABox.Name = "personABox";
            this.personABox.Size = new System.Drawing.Size(170, 23);
            this.personABox.TabIndex = 17;
            this.personABox.TextChanged += new System.EventHandler(this.PersonABox_TextChanged);
            // 
            // personBBox
            // 
            this.personBBox.Location = new System.Drawing.Point(12, 278);
            this.personBBox.Name = "personBBox";
            this.personBBox.Size = new System.Drawing.Size(170, 23);
            this.personBBox.TabIndex = 16;
            this.personBBox.WordWrap = false;
            this.personBBox.TextChanged += new System.EventHandler(this.PersonBBox_TextChanged);
            // 
            // showConnected
            // 
            this.showConnected.Location = new System.Drawing.Point(386, 260);
            this.showConnected.Name = "showConnected";
            this.showConnected.Size = new System.Drawing.Size(123, 41);
            this.showConnected.TabIndex = 29;
            this.showConnected.Text = "Show All Connected In Graph";
            this.showConnected.UseVisualStyleBackColor = true;
            this.showConnected.Click += new System.EventHandler(this.showConnected_Click);
            // 
            // AllConnectedPeople
            // 
            this.AllConnectedPeople.AutoSize = true;
            this.AllConnectedPeople.Location = new System.Drawing.Point(540, 217);
            this.AllConnectedPeople.Name = "AllConnectedPeople";
            this.AllConnectedPeople.Size = new System.Drawing.Size(121, 15);
            this.AllConnectedPeople.TabIndex = 30;
            this.AllConnectedPeople.Text = "All Connected People";
            // 
            // AllConnectedToPerson
            // 
            this.AllConnectedToPerson.Location = new System.Drawing.Point(432, 104);
            this.AllConnectedToPerson.Name = "AllConnectedToPerson";
            this.AllConnectedToPerson.Size = new System.Drawing.Size(77, 64);
            this.AllConnectedToPerson.TabIndex = 31;
            this.AllConnectedToPerson.Text = "Show All Connected To Person";
            this.AllConnectedToPerson.UseVisualStyleBackColor = true;
            this.AllConnectedToPerson.Click += new System.EventHandler(this.AllConnectedToPerson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AllConnectedToPerson);
            this.Controls.Add(this.AllConnectedPeople);
            this.Controls.Add(this.showConnected);
            this.Controls.Add(this.ContainsGraphID);
            this.Controls.Add(this.displayGraphList);
            this.Controls.Add(this.PersonLabel);
            this.Controls.Add(this.InsertBox);
            this.Controls.Add(this.TotalNodes);
            this.Controls.Add(this.AdjNode);
            this.Controls.Add(this.InsertDirectedEdge);
            this.Controls.Add(this.RemoveNode);
            this.Controls.Add(this.InsertNode);
            this.Controls.Add(this.nodeBID);
            this.Controls.Add(this.nodeAID);
            this.Controls.Add(this.personABox);
            this.Controls.Add(this.personBBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ContainsGraphID;
        private System.Windows.Forms.Label displayGraphList;
        private System.Windows.Forms.Label insLabel;
        private System.Windows.Forms.TextBox InsertBox;
        private System.Windows.Forms.Button TotalNodes;
        private System.Windows.Forms.Button AdjNode;
        private System.Windows.Forms.Button InsertDirectedEdge;
        private System.Windows.Forms.Button RemoveNode;
        private System.Windows.Forms.Button InsertNode;
        private System.Windows.Forms.Label nodeBID;
        private System.Windows.Forms.Label nodeAID;
        private System.Windows.Forms.TextBox Box;
        private System.Windows.Forms.TextBox PersonB;
        private System.Windows.Forms.Label PersonLabel;
        private System.Windows.Forms.TextBox personABox;
        private System.Windows.Forms.TextBox personBBox;
        private System.Windows.Forms.Button showConnected;
        private System.Windows.Forms.Label AllConnectedPeople;
        private System.Windows.Forms.Button AllConnectedToPerson;
    }
}

