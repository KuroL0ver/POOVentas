namespace POOVentas
{
    internal class ImpresionAImpresora : IImpresion
    {
        public void Imprimir(string texto)
        {
            // Lógica para imprimir el texto en una impresora
            Console.WriteLine($"Imprimiendo en impresora: {texto}");
        }
    }
    
    
}
