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
        Dim markertwo = New GMarkerGoogle(New PointLatLng(16, 16), GMarkerGoogleType.blue)
        Dim markerthree = New GMarkerGoogle(New PointLatLng(10, 10), GMarkerGoogleType.yellow)

        markersOverlay.Markers.Add(markerone)
        markersOverlay.Markers.Add(markertwo)
        markersOverlay.Markers.Add(markerthree)
        GMapControl1.Overlays.Add(markersOverlay)



        'polygon trial 
        Dim polyOverlay As New GMapOverlay("polygons")
        Dim points As IList(Of PointLatLng) = New List(Of PointLatLng)()
        points.Add(New PointLatLng(-25.969562, 32.585789))
        points.Add(New PointLatLng(-25.966205, 32.588171))
        points.Add(New PointLatLng(-25.968134, 32.591647))
        points.Add(New PointLatLng(-25.971684, 32.589759))
        Dim polygon As New GMapPolygon(points, "mypolygon")
        polygon.Fill = New SolidBrush(Color.FromArgb(50, Color.Red))
        polygon.Stroke = New Pen(Color.Red, 1)
        polyOverlay.Polygons.Add(polygon)
        GMapControl1.Overlays.Add(polyOverlay)

    End Sub
    Private Sub GmapControl1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles GMapControl1.MouseDoubleClick

        GMapControl1.Zoom = 2
    End Sub
End Class


