Module modAnimation
    Public Const EAST As Integer = 0
    Public Const NORTH As Integer = 90
    Public Const WEST As Integer = 180
    Public Const SOUTH As Integer = 270

    Public Const SPEED As Integer = 6

    Public decImageCounter As Decimal = 0.25

    Public intCharacterDirection As Integer = WEST
    Public intCookieDirection As Integer = NORTH

    Public charStandWest(4) As Image
    Public charStandEast(4) As Image

    Public charWalkWest(3) As Image
    Public charWalkEast(3) As Image
    Public charClimbNorth(1) As Image
    Public charClimbSouth(1) As Image

    Public Lvl1walls(39) As Label
    Public Lvl2walls(57) As Label
    Public Lvl3walls(37) As Label
    Public Lvl4walls(44) As Label
    Public Lvl5walls(34) As Label
    Public Lvl6walls(27) As Label

    Public Function WallCollisionLvl1(ByVal pBox As PictureBox) As Boolean
        For i As Integer = 0 To Lvl1walls.GetUpperBound(0)
            If pBox.Bounds.IntersectsWith(Lvl1walls(i).Bounds) Then
                Return True
            End If
        Next

        Return False
    End Function
    Public Function WallCollisionLvl2(ByVal pBox As PictureBox) As Boolean
        For i As Integer = 0 To Lvl2walls.GetUpperBound(0)
            If pBox.Bounds.IntersectsWith(Lvl2walls(i).Bounds) Then
                Return True
            End If
        Next

        Return False
    End Function
    Public Function WallCollisionLvl3(ByVal pBox As PictureBox) As Boolean
        For i As Integer = 0 To Lvl3walls.GetUpperBound(0)
            If pBox.Bounds.IntersectsWith(Lvl3walls(i).Bounds) Then
                Return True
            End If
        Next

        Return False
    End Function
    Public Function WallCollisionLvl4(ByVal pBox As PictureBox) As Boolean
        For i As Integer = 0 To Lvl4walls.GetUpperBound(0)
            If pBox.Bounds.IntersectsWith(Lvl4walls(i).Bounds) Then
                Return True
            End If
        Next

        Return False
    End Function
    Public Function WallCollisionLvl5(ByVal pBox As PictureBox) As Boolean
        For i As Integer = 0 To Lvl5walls.GetUpperBound(0)
            If pBox.Bounds.IntersectsWith(Lvl5walls(i).Bounds) Then
                Return True
            End If
        Next

        Return False
    End Function
    Public Function WallCollisionLvl6(ByVal pBox As PictureBox) As Boolean
        For i As Integer = 0 To Lvl6walls.GetUpperBound(0)
            If pBox.Bounds.IntersectsWith(Lvl6walls(i).Bounds) Then
                Return True
            End If
        Next

        Return False
    End Function
    Public Function CharMove(ByVal pBox As PictureBox, ByVal dir As Integer) As Point
        If dir = WEST Then
            Return New Point(pBox.Location.X - SPEED, pBox.Location.Y)
        End If

        If dir = EAST Then
            Return New Point(pBox.Location.X + SPEED, pBox.Location.Y)
        End If

        If dir = NORTH Then
            Return New Point(pBox.Location.X, pBox.Location.Y - SPEED)
        End If

        If dir = SOUTH Then
            Return New Point(pBox.Location.X, pBox.Location.Y + SPEED)
        End If

    End Function

    Public Function ChangeImage(ByVal imgArray() As Image) As Image
        decImageCounter += 0.25

        If decImageCounter > imgArray.GetUpperBound(0) Then
            decImageCounter = 0
        End If

        Return imgArray(decImageCounter)
    End Function
End Module
