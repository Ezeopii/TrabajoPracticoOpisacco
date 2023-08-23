using System;

// Clase de los drones
public class RepartidorDrone
{
    public void EntregarPedido(string pedido)
    {
        Console.WriteLine($"Entregando pedido con drone: {pedido}");
    }
}

// Singleton para gestionar los drones repartidores
public class GestorRepartidores
{
    private static GestorRepartidores _instancia;
    private RepartidorDrone _repartidorDrone;

    private GestorRepartidores()
    {
        
        _repartidorDrone = new RepartidorDrone();
    }

    public static GestorRepartidores Instancia
    {
        get
        {
            if (_instancia == null)
            {
                _instancia = new GestorRepartidores();
            }
            return _instancia;
        }
    }

    public RepartidorDrone ObtenerRepartidorDrone()
    {
        return _repartidorDrone;
    }
}


class Program
{
    static void Main(string[] args)
    {
        // Uso el gestor de repartidores para obtener a los drones
        var gestorRepartidores = GestorRepartidores.Instancia;
        var repartidorDrone = gestorRepartidores.ObtenerRepartidorDrone();

        repartidorDrone.EntregarPedido("Pedido #123");
    }
}
