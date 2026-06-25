using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulamentoBanco
{
    internal class Conta
    {
        private double _accountNumber; // Não pode ser alterado
        private String _holderName;// Pode ser alterado
        private double _amount;// metodo sacar e depositar - Pode ser negativo - Taxa de 5


        public Conta(double accountNumber, String holderName)
        {
            SetAccountNumber(accountNumber);
            SetHolderName(holderName);
        }

        public Conta(double accountNumber, String holderName,double amount): this(accountNumber,holderName)
        {
            SetAmount(amount);   
        }




        public double GetAccountNumber()
        {
            return _accountNumber;
        }

        private void SetAccountNumber(double accountNumber)
        {
             _accountNumber = accountNumber;
        }

        public String GetHolderName()
        {
            return _holderName;
        }

        public void SetHolderName(String holdername)
        {
             _holderName = holdername;
        }

        public double GetAmount()
        {
            return _amount;
        }
        public void SetAmount(double number)
        {
            _amount = number;
        }


        public double sake(double number)
        {
            double tax = 5.0;
            _amount -= number;
            _amount -= tax;
            return _amount;
        }
        public double deposit(double number)
        {
            _amount += number;
            return _amount;
        }

        public override string ToString()
        {
            return "Número da conta: "+_accountNumber +
                "" +
                "Titular da conta: {1} " + _holderName +
                "Valor na conta: {2}" + _amount;
        }
    }
}
