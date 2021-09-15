using System;
using System.Collections.Generic;
using System.Text;

namespace AppConta
{
    class ContaCorrente
    {
        private int Conta;
        private string Correntista;
        private double Saldo;

        public int Conta1 { get => Conta; set => Conta = value; }
        public string Correntista1 { get => Correntista; set => Correntista = value; }
        public double Saldo1 { get => Saldo; set => Saldo = value; }

        public ContaCorrente()
        {
             
        }

        public ContaCorrente(int Conta, string Correntista, float Saldo)
        {
            this.setConta(Conta);
            this.setCorrentista(Correntista);
            this.setSaldo(Saldo);
        }

        public void setConta(int Conta)
        {
            this.Conta1 = Conta;
        }

        public int getConta(int Conta)
        {
            return this.Conta1;
        }

        public void setCorrentista(string Correntista)
        {
            this.Correntista1 = Correntista;
        }

        public string getCorrentista(string Correntista)
        {
            return this.Correntista1;
        }

        public void setSaldo(double Saldo)
        {
            this.Saldo1 = Saldo;
        }

        public double getSaldo(double Saldo)
        {
            return this.Saldo1;
        }

        public void Depositar(double valor)
        {
            this.setSaldo(this.getSaldo(this.Saldo1) + valor);
        }

        public bool Saque(double valor)
        {
            if (this.getSaldo(this.Saldo1) >= valor)
            {
                this.setSaldo(this.getSaldo(this.Saldo1) - valor);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
