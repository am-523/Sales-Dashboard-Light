Imports LiveCharts
Imports LiveCharts.Defaults
Imports LiveCharts.Wpf

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chart()
        chartcolum()
    End Sub
    Private Sub chartcolum()
        CartesianChart2.Series = New SeriesCollection From {
                New ColumnSeries With {
                    .Title = "2015",
                    .Values = New ChartValues(Of Double) From {
                        10,
                        50,
                        39,
                        50,
                        40,
                        35
                    }
                }
            }
        CartesianChart2.Series.Add(New ColumnSeries With {
            .Title = "2020",
            .Values = New ChartValues(Of Double) From {
                11,
                56,
                42,
                  40,
                       60,
                        35
            }
        })
        CartesianChart2.Series(1).Values.Add(48.0R)
        CartesianChart2.AxisX.Add(New Axis With {
            .Title = "Sales Man",
            .Labels = {"Maria", "Susan", "Charles", "Frida", "Jaenab", "Roma"}
        })
        CartesianChart2.AxisY.Add(New Axis With {
            .Title = "Sold Apps",
            .LabelFormatter = Function(value) value.ToString("N")
        })
    End Sub

    Private Sub chart()

        CartesianChart1.Series = New SeriesCollection From {
              New LineSeries With {
                  .Values = New ChartValues(Of ObservablePoint) From {
                      New ObservablePoint(0, 10),
                      New ObservablePoint(4, 7),
                      New ObservablePoint(5, 3),
                      New ObservablePoint(7, 6),
                      New ObservablePoint(10, 8)
                  },
                  .PointGeometrySize = 25
              },
              New LineSeries With {
                  .Values = New ChartValues(Of ObservablePoint) From {
                      New ObservablePoint(0, 2),
                      New ObservablePoint(2, 5),
                      New ObservablePoint(3, 6),
                      New ObservablePoint(6, 8),
                      New ObservablePoint(10, 5)
                  },
                  .PointGeometrySize = 15
              },
              New LineSeries With {
                  .Values = New ChartValues(Of ObservablePoint) From {
                      New ObservablePoint(0, 4),
                      New ObservablePoint(5, 5),
                      New ObservablePoint(7, 7),
                      New ObservablePoint(9, 10),
                      New ObservablePoint(10, 9)
                  },
                  .PointGeometrySize = 15
              }
          }
    End Sub
End Class
