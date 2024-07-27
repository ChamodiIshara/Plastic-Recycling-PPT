Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Urban")
        ComboBox1.Items.Add("Sub Urban")
        ComboBox1.Items.Add("Rural")

        ComboBox2.Items.Add("1-2 Person")
        ComboBox2.Items.Add("3-4 Person")
        ComboBox2.Items.Add("5-6 Person")
        ComboBox2.Items.Add("Above 6 Person")

        ComboBox3.Items.Add("Daily")
        ComboBox3.Items.Add("Once a week")
        ComboBox3.Items.Add("Few days a week")

        ComboBox4.Items.Add("1")
        ComboBox4.Items.Add("1-10")
        ComboBox4.Items.Add("10-20")
        ComboBox4.Items.Add("20-30")
        ComboBox4.Items.Add("30-40")

        ComboBox5.Items.Add("Burry in the garden")
        ComboBox5.Items.Add("Burn")
        ComboBox5.Items.Add("Give to the garbage tractor/lorry")
        ComboBox5.Items.Add("Give to recycling")

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
       

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox5.Text = ""
      
       

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("file:///H:/RAT-IT-2021-F-0045%20-%20Individual%20Project%20(1st%20sem)/Budject_Analysis.accdb")


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
