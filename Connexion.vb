
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Data.Sql
Module connexion
    'Public connetionString As String = "Data Source=DESKTOP-TAB82B4\SQL2017;Initial Catalog=System_Warehouse_TN;User ID=;Password=;Integrated Security=True;"
    Public connetionString As String = "Data Source=192.168.165.2\SQL2017;Initial Catalog=System_Warehouse_TN;User ID=adminpack;Password=Anairda&2105;Integrated Security=True;"
    ' Public connetionString As String = "Data Source=DESKTOP-AAJBCC8\WALID;Initial Catalog=Statystyka_TN;Integrated Security=True;"
    ' Public connetionString As String = "Data Source=192.168.1.15;Initial Catalog=Statystyka_TN;User ID=conn1;Password=infosef;Integrated Security=True;"


    Public conn As SqlConnection = New SqlConnection(connetionString)
    Public UserLogin As String
    Public MachineName As String
    Public confirmationAction As Boolean = False

End Module

