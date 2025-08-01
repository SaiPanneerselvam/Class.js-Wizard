Imports System.Net.Http
Imports System.IO
Imports System.IO.Compression
Public Class Form1
    Dim username As String = Environment.UserName
    Dim installed As Boolean = False
    Dim path As String = $"C:\Users\{Environment.UserName}\Classjs\install\class.js-main\app\installed.info"

    Private Async Function DownloadAndExtract() As Task
        Dim url As String = "https://github.com/SaiPanneerselvam/class.js/archive/refs/heads/main.zip"
        Dim userFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        Dim targetFolder As String = userFolder & "\Classjs\install\"
        Dim zipPath As String = userFolder & "\Classjs\classjs.zip"

        Try
            If Not Directory.Exists(targetFolder) Then
                Directory.CreateDirectory(targetFolder)
            End If

            Using client As New HttpClient()
                Dim data As Byte() = Await client.GetByteArrayAsync(url)
                File.WriteAllBytes(zipPath, data)
            End Using

            If Directory.Exists(targetFolder) Then
                Directory.Delete(targetFolder, True)
                Directory.CreateDirectory(targetFolder)
            End If

            ZipFile.ExtractToDirectory(zipPath, targetFolder)

        Catch ex As Exception
            MessageBox.Show("Download or unzip error: " & ex.Message)
        End Try
    End Function
    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim url As String = "https://raw.githubusercontent.com/SaiPanneerselvam/class.js/refs/heads/main/app/version.info"
        Using client As New HttpClient()
            Try
                Dim content As String = Await client.GetStringAsync(url)
                Label1.Text = content
            Catch ex As Exception
                Label1.Text = "Error. Click to try again."
            End Try
        End Using

        If IO.File.Exists(path) Then
            installed = True
            Label7.Text = "Installed"
            Label7.ForeColor = Color.Green
        Else
            installed = False
            Label7.Text = "Not Installed"
            Label7.ForeColor = Color.Red
        End If


    End Sub

    Private Async Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim url As String = "https://raw.githubusercontent.com/SaiPanneerselvam/class.js/refs/heads/main/app/version.info"
        Using client As New HttpClient()
            Try
                Dim content As String = Await client.GetStringAsync(url)
                Label1.Text = content
            Catch ex As Exception
                Label1.Text = "[Click to try again]"
                MsgBox("Error loading version: Please connect to the internet.", MsgBoxStyle.Critical, "Class.js Error")
            End Try
        End Using
    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Await DownloadAndExtract()
        MsgBox("Successfully installed Class.js", MsgBoxStyle.Information, "Class.js Installer")
        MsgBox("The Application will now restart.", MsgBoxStyle.Information, "Class.js Installer")

        Application.Restart()
        Environment.Exit(0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim userFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        Dim installFolder As String = userFolder & "\Classjs\install\"

        Try
            If Directory.Exists(installFolder) Then
                Directory.Delete(installFolder, True)
                MessageBox.Show("Uninstalled successfully.")
                MsgBox("Successfully uninstalled Class.js", MsgBoxStyle.Information, "Class.js Installer")
                MsgBox("The Application will now restart.", MsgBoxStyle.Information, "Class.js Installer")

                Application.Restart()
                Environment.Exit(0)
            Else
                MessageBox.Show("Nothing to uninstall.")
            End If
        Catch ex As Exception
            MessageBox.Show("Uninstall failed: " & ex.Message)
        End Try
    End Sub
End Class
