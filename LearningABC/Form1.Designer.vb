<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CapLetter = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SmallLetter = New System.Windows.Forms.Label()
        Me.Item1 = New System.Windows.Forms.Button()
        Me.Item2 = New System.Windows.Forms.Button()
        Me.Item3 = New System.Windows.Forms.Button()
        Me.Prev = New System.Windows.Forms.Button()
        Me.Nxt = New System.Windows.Forms.Button()
        Me.MusicBtn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.Image = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Teal
        Me.GroupBox1.Controls.Add(Me.CapLetter)
        Me.GroupBox1.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(36, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 269)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Capital Lettter"
        '
        'CapLetter
        '
        Me.CapLetter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CapLetter.Font = New System.Drawing.Font("Courier New", 140.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CapLetter.ForeColor = System.Drawing.Color.Black
        Me.CapLetter.Location = New System.Drawing.Point(16, 27)
        Me.CapLetter.Name = "CapLetter"
        Me.CapLetter.Size = New System.Drawing.Size(281, 230)
        Me.CapLetter.TabIndex = 0
        Me.CapLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Teal
        Me.GroupBox2.Controls.Add(Me.SmallLetter)
        Me.GroupBox2.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(36, 321)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(303, 240)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Small Letter"
        '
        'SmallLetter
        '
        Me.SmallLetter.Font = New System.Drawing.Font("Courier New", 120.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SmallLetter.ForeColor = System.Drawing.Color.Black
        Me.SmallLetter.Location = New System.Drawing.Point(21, 27)
        Me.SmallLetter.Name = "SmallLetter"
        Me.SmallLetter.Size = New System.Drawing.Size(259, 201)
        Me.SmallLetter.TabIndex = 0
        Me.SmallLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Item1
        '
        Me.Item1.BackColor = System.Drawing.Color.DarkMagenta
        Me.Item1.Font = New System.Drawing.Font("Segoe Script", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Item1.ForeColor = System.Drawing.Color.Black
        Me.Item1.Location = New System.Drawing.Point(584, 384)
        Me.Item1.Name = "Item1"
        Me.Item1.Size = New System.Drawing.Size(220, 52)
        Me.Item1.TabIndex = 4
        Me.Item1.UseVisualStyleBackColor = False
        '
        'Item2
        '
        Me.Item2.BackColor = System.Drawing.Color.DarkMagenta
        Me.Item2.Font = New System.Drawing.Font("Segoe Script", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Item2.ForeColor = System.Drawing.Color.Black
        Me.Item2.Location = New System.Drawing.Point(796, 451)
        Me.Item2.Name = "Item2"
        Me.Item2.Size = New System.Drawing.Size(220, 52)
        Me.Item2.TabIndex = 5
        Me.Item2.UseVisualStyleBackColor = False
        '
        'Item3
        '
        Me.Item3.BackColor = System.Drawing.Color.DarkMagenta
        Me.Item3.Font = New System.Drawing.Font("Segoe Script", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Item3.ForeColor = System.Drawing.Color.Black
        Me.Item3.Location = New System.Drawing.Point(999, 518)
        Me.Item3.Name = "Item3"
        Me.Item3.Size = New System.Drawing.Size(220, 52)
        Me.Item3.TabIndex = 6
        Me.Item3.UseVisualStyleBackColor = False
        '
        'Prev
        '
        Me.Prev.BackColor = System.Drawing.Color.Purple
        Me.Prev.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prev.ForeColor = System.Drawing.Color.Black
        Me.Prev.Location = New System.Drawing.Point(384, 597)
        Me.Prev.Name = "Prev"
        Me.Prev.Size = New System.Drawing.Size(140, 48)
        Me.Prev.TabIndex = 7
        Me.Prev.Text = "Prev"
        Me.Prev.UseVisualStyleBackColor = False
        '
        'Nxt
        '
        Me.Nxt.BackColor = System.Drawing.Color.Purple
        Me.Nxt.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nxt.ForeColor = System.Drawing.Color.Black
        Me.Nxt.Location = New System.Drawing.Point(732, 597)
        Me.Nxt.Name = "Nxt"
        Me.Nxt.Size = New System.Drawing.Size(132, 48)
        Me.Nxt.TabIndex = 8
        Me.Nxt.Text = "Next"
        Me.Nxt.UseVisualStyleBackColor = False
        '
        'MusicBtn
        '
        Me.MusicBtn.BackColor = System.Drawing.Color.Transparent
        Me.MusicBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MusicBtn.ForeColor = System.Drawing.Color.Maroon
        Me.MusicBtn.Location = New System.Drawing.Point(64, 655)
        Me.MusicBtn.Name = "MusicBtn"
        Me.MusicBtn.Size = New System.Drawing.Size(47, 42)
        Me.MusicBtn.TabIndex = 9
        Me.MusicBtn.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 300
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.Red
        Me.CloseBtn.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.ForeColor = System.Drawing.Color.Black
        Me.CloseBtn.Location = New System.Drawing.Point(1148, 655)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(71, 48)
        Me.CloseBtn.TabIndex = 10
        Me.CloseBtn.Text = "Exit"
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'Image
        '
        Me.Image.BackColor = System.Drawing.Color.Transparent
        Me.Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Image.Location = New System.Drawing.Point(436, 12)
        Me.Image.Name = "Image"
        Me.Image.Size = New System.Drawing.Size(754, 341)
        Me.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Image.TabIndex = 3
        Me.Image.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1323, 749)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.MusicBtn)
        Me.Controls.Add(Me.Nxt)
        Me.Controls.Add(Me.Prev)
        Me.Controls.Add(Me.Item3)
        Me.Controls.Add(Me.Item2)
        Me.Controls.Add(Me.Item1)
        Me.Controls.Add(Me.Image)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "ABC Learning For Kids"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CapLetter As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SmallLetter As Label
    Friend WithEvents Image As PictureBox
    Friend WithEvents Item1 As Button
    Friend WithEvents Item2 As Button
    Friend WithEvents Item3 As Button
    Friend WithEvents Prev As Button
    Friend WithEvents Nxt As Button
    Friend WithEvents MusicBtn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CloseBtn As Button
End Class
