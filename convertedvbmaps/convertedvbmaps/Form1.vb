
Imports GMap.NET
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace WindowsFormsApplication1
    Partial Public Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub gMapControl1_Load(sender As Object, e As EventArgs)
            Me.GMapControl1.Zoom = +1
        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs)


            ' Initialize map:
            GMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly
            GMapControl1.Position = New GMap.NET.PointLatLng(0.06, 34)

            'Placing a marker on a certain position
            Dim markersOverlay As New GMapOverlay("markers")
            Dim marker As New GMarkerGoogle(New PointLatLng(0.06, 34.2), GMarkerGoogleType.green)
            marker.ToolTipText = "This is the first marker we put up"

            Dim masenomarker As New GMarkerGoogle(New PointLatLng(45, 45), GMarkerGoogleType.blue)
            masenomarker.ToolTipText = "This is the second marker we put up"
            masenomarker.ToolTipMode = MarkerTooltipMode.OnMouseOver

            Dim thirdmarker As New GMarkerGoogle(New PointLatLng(-45, 45), GMarkerGoogleType.red)
            thirdmarker.ToolTipText = "This is the third marker we put up"
            thirdmarker.ToolTipMode = MarkerTooltipMode.OnMouseOver

            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver
            markersOverlay.Markers.Add(marker)
            GMapControl1.Overlays.Add(markersOverlay)


            markersOverlay.Markers.Add(masenomarker)
            GMapControl1.Overlays.Add(markersOverlay)

            markersOverlay.Markers.Add(marker)
            GMapControl1.Overlays.Add(markersOverlay)


            markersOverlay.Markers.Add(thirdmarker)
            GMapControl1.Overlays.Add(markersOverlay)
        End Sub

        Friend WithEvents GMapControl1 As GMapControl

        Private Sub InitializeComponent()
            Me.GMapControl1 = New GMap.NET.WindowsForms.GMapControl()
            Me.SuspendLayout()
            '
            'GMapControl1
            '
            Me.GMapControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GMapControl1.AutoScroll = True
            Me.GMapControl1.Bearing = 0!
            Me.GMapControl1.CanDragMap = True
            Me.GMapControl1.EmptyTileColor = System.Drawing.Color.Navy
            Me.GMapControl1.GrayScaleMode = False
            Me.GMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
            Me.GMapControl1.LevelsKeepInMemmory = 5
            Me.GMapControl1.Location = New System.Drawing.Point(-1, -2)
            Me.GMapControl1.MarkersEnabled = True
            Me.GMapControl1.MaxZoom = 10
            Me.GMapControl1.MinZoom = 5
            Me.GMapControl1.MouseWheelZoomEnabled = True
            Me.GMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
            Me.GMapControl1.Name = "GMapControl1"
            Me.GMapControl1.NegativeMode = False
            Me.GMapControl1.PolygonsEnabled = True
            Me.GMapControl1.RetryLoadTile = 0
            Me.GMapControl1.RoutesEnabled = True
            Me.GMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
            Me.GMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
            Me.GMapControl1.ShowTileGridLines = False
            Me.GMapControl1.Size = New System.Drawing.Size(689, 522)
            Me.GMapControl1.TabIndex = 0
            Me.GMapControl1.Zoom = 5.0R
            '
            'Form1
            '
            Me.ClientSize = New System.Drawing.Size(689, 519)
            Me.Controls.Add(Me.GMapControl1)
            Me.Name = "Form1"
            Me.ResumeLayout(False)

        End Sub

        Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub GMapControl1_Load_1(sender As Object, e As EventArgs) Handles GMapControl1.Load

        End Sub
    End Class


End Namespace

