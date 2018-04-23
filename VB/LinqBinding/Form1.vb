Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace LinqBinding
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private context As New NorthwindDataContext()

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim products As New BindingSource(context.Products, "")
			Dim categories As New BindingSource(context.Categories, "")
			repositoryItemLookUpEdit1.DataSource = categories
			gridControl1.DataSource = products
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			context.SubmitChanges()
		End Sub
	End Class
End Namespace
