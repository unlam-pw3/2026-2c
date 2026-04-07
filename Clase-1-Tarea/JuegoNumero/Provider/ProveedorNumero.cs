using System;

public class ProveedorNumero : IProveedorNumero
{
	private readonly Random _random;
	public ProveedorNumero()
	{
		_random = new Random();
	}
	public int ObtenerNumeroSecreto()
	{
		return _random.Next(1, 101); // Genera un número aleatorio entre 1 y 100
	}
}


