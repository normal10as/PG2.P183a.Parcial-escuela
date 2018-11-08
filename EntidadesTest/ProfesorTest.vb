Imports Entidades

Module ProfesorTest

    Sub Main()
        Dim p1 As New Profesor("Pepe", 123, 987)
        Console.WriteLine("Nombre: " & p1.Nombre)
        Console.WriteLine("DNI: " & p1.DNI)
        Console.WriteLine("Legajo: " & p1.Legajo)
        Console.WriteLine("ToString(): " & p1.ToString())

        Dim a1 As New Asignatura("Matematica 1")
        p1.AddAsignatura(a1)
        p1.AddAsignatura(New Asignatura("Matematica 2"))
        p1.AddAsignatura(New Asignatura("Matematica 3"))

        MostrarTodasLasAsignaturas(p1)
        Console.WriteLine("Eliminar " & a1.ToString)
        p1.RemoveAsignatura(a1)
        MostrarTodasLasAsignaturas(p1)
    End Sub
End Module
