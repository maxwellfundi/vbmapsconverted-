Imports GMap.NET
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers

Public Class Form1
    Private Sub GMapControl1_Load(sender As Object, e As EventArgs) Handles GMapControl1.Load
        ' Initialize map
        GMapControl1.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance
        GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly
        GMapControl1.Position = New GMap.NET.PointLatLng(0, 0)
        ' gMapControl.SetPositionByKeywords("Embu, kenya")

        ' Placing a marker on a certain position
        Dim markersOverlay = New GMapOverlay("markers")
        Dim markerone = New GMarkerGoogle(New PointLatLng(1, 0), GMarkerGoogleType.green)
        Dim markertwo = New GMarkerGoogle(New PointLatLng(0.07, 1), GMarkerGoogleType.blue)
        Dim markerthree = New GMarkerGoogle(New PointLatLng(10, 10), GMarkerGoogleType.yellow)


        markersOverlay.Markers.Add(markerone)
        markersOverlay.Markers.Add(markertwo)
        markersOverlay.Markers.Add(markerthree)
        GMapControl1.Overlays.Add(markersOverlay)




        ' Add new code here

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class






