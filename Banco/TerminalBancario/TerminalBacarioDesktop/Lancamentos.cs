//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TerminalBacarioDesktop
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lancamentos
    {
        public int Id { get; set; }
        public System.DateTime Data { get; set; }
        public int ContaId { get; set; }
        public int Operacao { get; set; }
        public string Historico { get; set; }
        public decimal Valor { get; set; }
    
        public virtual Conta Conta { get; set; }
    }
}