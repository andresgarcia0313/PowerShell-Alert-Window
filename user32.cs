using System;
using System.Runtime.InteropServices;

/// <summary>
/// Proporciona acceso a la biblioteca de funciones User32.dll en Windows.
/// </summary>
public class User32 {
    
    /// <summary>
    /// Muestra un cuadro de diálogo de mensaje.
    /// </summary>
    /// <param name="hWnd">Manejo de ventana del propietario del cuadro de diálogo.</param>
    /// <param name="text">Texto que se mostrará en el cuadro de diálogo.</param>
    /// <param name="caption">Título del cuadro de diálogo.</param>
    /// <param name="type">Tipo de cuadro de diálogo y botones mostrados.</param>
    /// <returns>El resultado del cuadro de diálogo, que indica el botón seleccionado por el usuario.</returns>
    [DllImport("user32.dll", EntryPoint = "MessageBox")]
    public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);
}
