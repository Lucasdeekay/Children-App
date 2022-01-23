Public Class Form1

    Dim caps As Array = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
    Dim low As Array = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
    Dim index As Integer = 0

    Dim BtnIndex

    Dim words As Array = {
        {"APPLE", "ANTELOPE", "AEROPLANE"},
        {"BALL", "BAG", "BIRD"},
        {"CAT", "CAR", "CUP"},
        {"DOG", "DUCK", "DONKEY"},
        {"EGG", "EAGLE", "ELEPHANT"},
        {"FISH", "FLOWER", "FROG"},
        {"GOAT", "GIRAFFE", "GRASS"},
        {"HOUSE", "HORSE", "HEN"},
        {"INK", "IRON", "ICE"},
        {"JUG", "JAGUAR", "JUICE"},
        {"KETTLE", "KITE", "KAYAK"},
        {"LAMP", "LAMB", "LADDER"},
        {"MONKEY", "MAIZE", "MANGO"},
        {"NURSE", "NEST", "NEWSPAPER"},
        {"ORANGE", "ONION", "OAK"},
        {"PARROT", "PEAR", "PENCIL"},
        {"QUEEN", "QUAIL", "QUILL"},
        {"RABBIT", "RADIO", "RACKET"},
        {"SHOE", "SHIP", "SUN"},
        {"TELEVISION", "TABLE", "TAP"},
        {"UMBRELLA", "UNICORN", "URANIUM"},
        {"VIOLIN", "VAN", "VASE"},
        {"WATCH", "WINDOW", "WOMAN"},
        {"XYLOPHONE", "X-RAY", "XMAS TREE"},
        {"YOYO", "YACTH", "YOGHURT"},
        {"ZEBRA", "ZIP", "ZUCCHINI"}
    }

    Dim Rnd As New Random()
    Dim B_color

    Private Sub LearningABC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MusicBtn.Text = "🔊"
        My.Computer.Audio.Play("C:\Users\Lucas Dennis\Downloads\music.wav", AudioPlayMode.BackgroundLoop)

        B_color = Color.FromArgb(255, Rnd.Next(0, 256), Rnd.Next(0, 256), Rnd.Next(0, 256))

        GroupBox1.BackColor = B_color
        GroupBox2.BackColor = B_color
        Item1.BackColor = B_color
        Item2.BackColor = B_color
        Item3.BackColor = B_color

        Nxt.BackColor = B_color
        Prev.BackColor = B_color

        CapLetter.Text = caps.GetValue(index)
        SmallLetter.Text = low.GetValue(index)
        Item1.Text = words.GetValue(index, 0)
        Item2.Text = words.GetValue(index, 1)
        Item3.Text = words.GetValue(index, 2)
        Me.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Lucas Dennis\Downloads\john-towner-JgOeRuGD_Y4-unsplash.jpg")
        Image.Image = System.Drawing.Image.FromFile("C:\Users\Lucas Dennis\Downloads\" & Item1.Text & ".jpg")
    End Sub

    Private Async Sub Prev_Click(sender As Object, e As EventArgs) Handles Prev.Click
        B_color = Color.FromArgb(255, Rnd.Next(0, 256), Rnd.Next(0, 256), Rnd.Next(0, 256))

        BtnIndex = 0

        GroupBox1.BackColor = B_color
        GroupBox2.BackColor = B_color
        Item1.BackColor = B_color
        Item2.BackColor = B_color
        Item3.BackColor = B_color

        Nxt.BackColor = B_color
        Prev.BackColor = B_color

        Try
            index -= 1
            Nxt.Show()
            CapLetter.Text = caps.GetValue(index)
            SmallLetter.Text = low.GetValue(index)
            Item1.Text = words.GetValue(index, 0)
            Item2.Text = words.GetValue(index, 1)
            Item3.Text = words.GetValue(index, 2)
            Image.Image = System.Drawing.Image.FromFile("C:\Users\Lucas Dennis\Downloads\" & Item1.Text & ".jpg")
        Catch IndexOutOfBoundException As Exception
            index = 0
            Prev.Hide()
        End Try
    End Sub

    Private Async Sub Nxt_Click(sender As Object, e As EventArgs) Handles Nxt.Click
        B_color = Color.FromArgb(255, Rnd.Next(0, 256), Rnd.Next(0, 256), Rnd.Next(0, 256))

        BtnIndex = 0

        GroupBox1.BackColor = B_color
        GroupBox2.BackColor = B_color
        Item1.BackColor = B_color
        Item2.BackColor = B_color
        Item3.BackColor = B_color

        Nxt.BackColor = B_color
        Prev.BackColor = B_color

        Try
            index += 1
            Prev.Show()
            CapLetter.Text = caps.GetValue(index)
            SmallLetter.Text = low.GetValue(index)
            Item1.Text = words.GetValue(index, 0)
            Item2.Text = words.GetValue(index, 1)
            Item3.Text = words.GetValue(index, 2)
            Image.Image = System.Drawing.Image.FromFile("C:\Users\Lucas Dennis\Downloads\" & Item1.Text & ".jpg")
 
        Catch IndexOutOfBoundException As Exception
            index = caps.Length - 1
            Nxt.Hide()
        End Try
    End Sub

    Private Sub Item1_Click(sender As Object, e As EventArgs) Handles Item1.Click
        BtnIndex = 1
        Timer1.Start()

        Item2.BackColor = B_color
        Item3.BackColor = B_color
        Dim word As String = Item1.Text
        Image.Image = System.Drawing.Image.FromFile("C:\Users\Lucas Dennis\Downloads\" & word & ".jpg")
    End Sub

    Private Sub Item2_Click(sender As Object, e As EventArgs) Handles Item2.Click
        BtnIndex = 2
        Timer1.Start()

        Item1.BackColor = B_color
        Item3.BackColor = B_color
        Dim word As String = Item2.Text
        Image.Image = System.Drawing.Image.FromFile("C:\Users\Lucas Dennis\Downloads\" & word & ".jpg")
    End Sub

    Private Sub Item3_Click(sender As Object, e As EventArgs) Handles Item3.Click
        BtnIndex = 3
        Timer1.Start()

        Item1.BackColor = B_color
        Item2.BackColor = B_color
        Dim word As String = Item3.Text
        Image.Image = System.Drawing.Image.FromFile("C:\Users\Lucas Dennis\Downloads\" & word & ".jpg")
    End Sub

    Private Sub MusicBtn_Click(sender As Object, e As EventArgs) Handles MusicBtn.Click
        If MusicBtn.Text = "🔇" Then
            My.Computer.Audio.Play("C:\Users\Lucas Dennis\Downloads\music.wav", AudioPlayMode.BackgroundLoop)
            MusicBtn.Text = "🔊"
        Else
            My.Computer.Audio.Stop()
            MusicBtn.Text = "🔇"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case BtnIndex
            Case 1
                If Item1.BackColor = B_color Then
                    Item1.BackColor = Color.White
                Else
                    Item1.BackColor = B_color
                End If
            Case 2
                If Item2.BackColor = B_color Then
                    Item2.BackColor = Color.White
                Else
                    Item2.BackColor = B_color
                End If
            Case 3
                If Item3.BackColor = B_color Then
                    Item3.BackColor = Color.White
                Else
                    Item3.BackColor = B_color
                End If
        End Select
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub


End Class
