<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.SuspendLayout()
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
		Me.TableLayoutPanel1.ColumnCount = 6
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.TableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 27)
		Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 3
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33223!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33223!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33556!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(209, 107)
		Me.TableLayoutPanel1.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.SandyBrown
		Me.Label1.Cursor = System.Windows.Forms.Cursors.SizeAll
		Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(0, 0)
		Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(179, 27)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Label1"
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.SandyBrown
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
		Me.Label2.Font = New System.Drawing.Font("Webdings", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(178, 0)
		Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(31, 27)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "r"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Label2.UseCompatibleTextRendering = True
		'
		'Timer1
		'
		Me.Timer1.Enabled = True
		Me.Timer1.Interval = 1000
		'
		'Form1
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.SystemColors.InactiveBorder
		Me.ClientSize = New System.Drawing.Size(209, 134)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
		Me.Name = "Form1"
		Me.Text = "Binäruhr"
		Me.TransparencyKey = System.Drawing.SystemColors.InactiveBorder
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
