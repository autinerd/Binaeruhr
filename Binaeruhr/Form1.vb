Public Class Form1
	Dim lbSeconds(6) As Label
	Dim lbMinutes(6) As Label
	Dim lbHours(6) As Label

	Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
		For i = 0 To 5
			lbSeconds(i) = New Label()
			With lbSeconds(i)
				.AutoSize = False
				.Dock = DockStyle.Fill
				.Tag = i
				.Name = "lbSeconds" & i
				.Font = New Font(FontFamily.GenericSansSerif, TableLayoutPanel1.RowStyles.Item(2).Height - 2, FontStyle.Regular, GraphicsUnit.Pixel)
				.Text = "0" 'CStr(0)
			End With
			TableLayoutPanel1.Controls.Add(lbSeconds(i), i + 5 - (2 * i), 2)
		Next
		For i = 0 To 5
			lbHours(i) = New Label()
			With lbHours(i)
				.AutoSize = False
				.Dock = DockStyle.Fill
				.Tag = i
				.Name = "lbHours" & i
				.Font = New Font(FontFamily.GenericSansSerif, TableLayoutPanel1.RowStyles.Item(0).Height - 2, FontStyle.Regular, GraphicsUnit.Pixel)
				.Text = "0" 'CStr(0)
			End With
			TableLayoutPanel1.Controls.Add(lbHours(i), i + 5 - (2 * i), 0)
		Next
		For i = 0 To 5
			lbMinutes(i) = New Label()
			With lbMinutes(i)
				.AutoSize = False
				.Dock = DockStyle.Fill
				.Tag = i
				.Name = "lbMinutes" & i
				.Font = New Font(FontFamily.GenericSansSerif, TableLayoutPanel1.RowStyles.Item(1).Height - 2, FontStyle.Regular, GraphicsUnit.Pixel)
				.Text = "0" 'CStr(0)
			End With
			TableLayoutPanel1.Controls.Add(lbMinutes(i), i + 5 - (2 * i), 1)
		Next
		Label1.Text = Text
		TopMost = True
	End Sub


	Private Sub Label1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Label1.MouseDown
		If e.Button = Windows.Forms.MouseButtons.Left Then
			Label1.Capture = False
			WndProc(Message.Create(Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
		End If
	End Sub

	Private Sub Label2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label2.Click
		Close()
	End Sub

	Sub StundeRechnen()
		Dim tmpQuotient, Hours As Integer
		Hours = Now.Hour
		lbHours(0).Text = Hours Mod 2
		tmpQuotient = CInt(Math.Truncate(Hours / 2))
		lbHours(1).Text = tmpQuotient Mod 2
		tmpQuotient = CInt(Math.Truncate(tmpQuotient / 2))
		lbHours(2).Text = tmpQuotient Mod 2
		tmpQuotient = CInt(Math.Truncate(tmpQuotient / 2))
		lbHours(3).Text = tmpQuotient Mod 2
		tmpQuotient = CInt(Math.Truncate(tmpQuotient / 2))
		lbHours(4).Text = tmpQuotient Mod 2
	End Sub
	Sub MinuteRechnen()
		Dim tmpQuotient, Minutes As Integer
		Minutes = Now.Minute
		lbMinutes(0).Text = Minutes Mod 2
		tmpQuotient = CInt(Math.Truncate(Minutes / 2))
		lbMinutes(1).Text = tmpQuotient Mod 2
		tmpQuotient = CInt(Math.Truncate(tmpQuotient / 2))
		lbMinutes(2).Text = tmpQuotient Mod 2
		tmpQuotient = CInt(Math.Truncate(tmpQuotient / 2))
		lbMinutes(3).Text = tmpQuotient Mod 2
		tmpQuotient = CInt(Math.Truncate(tmpQuotient / 2))
		lbMinutes(4).Text = tmpQuotient Mod 2
		tmpQuotient = CInt(Math.Truncate(tmpQuotient / 2))
		lbMinutes(5).Text = tmpQuotient Mod 2
	End Sub
	Sub SekundeRechnen()
		Dim tmpQuotient, Seconds As Integer
		Seconds = Now.Second
		lbSeconds(0).Text = Seconds Mod 2
		tmpQuotient = CInt(Math.Truncate(Seconds / 2))
		lbSeconds(1).Text = tmpQuotient Mod 2
		tmpQuotient = CInt(Math.Truncate(tmpQuotient / 2))
		lbSeconds(2).Text = tmpQuotient Mod 2
		tmpQuotient = CInt(Math.Truncate(tmpQuotient / 2))
		lbSeconds(3).Text = tmpQuotient Mod 2
		tmpQuotient = CInt(Math.Truncate(tmpQuotient / 2))
		lbSeconds(4).Text = tmpQuotient Mod 2
		tmpQuotient = CInt(Math.Truncate(tmpQuotient / 2))
		lbSeconds(5).Text = tmpQuotient Mod 2
	End Sub

	Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
		StundeRechnen()
		MinuteRechnen()
		SekundeRechnen()
	End Sub

	Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
		Timer1_Tick(Timer1, New EventArgs())
	End Sub
End Class
