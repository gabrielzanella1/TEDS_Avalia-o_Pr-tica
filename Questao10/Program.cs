//----------> Exemplo Prático

Regular reserva1 = new Regular("Cancun", true);
reserva1.Verificar();
reserva1.ReservarVoo();
reserva1.CancelarVoo();
reserva1.StatusReserva();
Console.WriteLine();

//-----------------------------------------------

Upgrade reserva2 = new Upgrade("Maldivas", true);
reserva2.Verificar();
reserva2.ReservarVoo();
reserva2.CancelarVoo();
reserva2.StatusReserva();
Console.WriteLine();


//-----------------------------------------------

GrupoGrande reserva3 = new GrupoGrande("Ilha do Mel", true);
reserva3.Verificar();
reserva3.ReservarVoo();
reserva3.CancelarVoo();
reserva3.StatusReserva();