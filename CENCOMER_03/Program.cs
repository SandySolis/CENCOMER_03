using Microsoft.VisualBasic;

Console.Write("¿Cuántas respuestas correctas obtuvo?: ");
int respuestas = int.Parse(Console.ReadLine());
Console.WriteLine("Usted es mayor o menor de edad: ");
Console.WriteLine("(A) MAYOR DE EDAD : ");
Console.WriteLine("(B) MENOR DE EDAD : ");
char edad = char.Parse(Console.ReadLine());

double cantidad = 0;

switch (edad)
{
	case 'A':
		if (respuestas<3)
		{
			cantidad = 30;
		}
		else
		{
			cantidad = 50;
		}
		break;

	case 'B':
        if (respuestas < 3)
        {
            cantidad = 50;
        }
        else
        {
            cantidad = 80;
        }
        break;
}

int extra = (int)(edad * 5.00 + respuestas * 2.00);
int total = (int)(cantidad + extra);


Console.WriteLine("El monto para el ganador es: S/." + total);
