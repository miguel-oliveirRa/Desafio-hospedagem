using System;
using Models;

List<Pessoa> hospedes = new();

Pessoa p1 = new("Hóspede", "1");
Pessoa p2 = new("Hóspede", "2");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new(tipo: "Premium", capacidade: 1, valorDiaria: 30);

Reserva reserva = new(hospedes, suite, diasReservados: 5);

reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");