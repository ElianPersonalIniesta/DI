using Ejercicio5;

Console.WriteLine("Hello, World!");
//Boleto boleto = new Boleto();
//boleto.creacionBoleto();
Boleto[] boletos = creacionBoletos();
foreach (Boleto bol in boletos)
{
    Console.WriteLine(bol.ToString());
}

Boleto[] creacionBoletos()
{
    Boleto[] once = new Boleto[100];
    bool flag = true;
    bool flagDos;
    int contador = 0;
    do //HACEMOS MIENTRAS FLAG SEA FALSE Y CONTADOR MENOR DE 100
    {
        once[contador] = new Boleto();
        once[contador].creacionBoleto();//CREAMOS BOLETO
        flag = false;
        if (contador > 0) //SI EL CONTADOR ES MAYOR A 0 ENTONCES USAMOS EQUALS
        {
            for (int i = 0; i < contador; i++) // COMPARAMOS EL BOLETO ACTUAL AL RESTO
            {
                flagDos = once[contador].Equals(once[i]); //SI SALE TRUE EN ALGUN MOMENTO CAMBIA EL ESTADO DE FLAG
                if (flagDos == true)
                {
                    flag = true;
                }
            }

        }
        if (!flag) contador++;
    }
    while (!flag && contador < 100);
    return once;

} 
