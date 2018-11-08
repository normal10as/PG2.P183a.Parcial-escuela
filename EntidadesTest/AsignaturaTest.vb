Imports Entidades

Module AsignaturaTest
    Sub main()
        Dim a1 As New Asignatura("Matematica")
        Console.WriteLine(a1.Nombre)
        ' asignatura.tostring necesita un profesor
        Dim p1 As New Profesor("Pepe", 123, 987)
        p1.AddAsignatura(a1)
        Console.WriteLine(a1.ToString)
    End Sub
End Module
