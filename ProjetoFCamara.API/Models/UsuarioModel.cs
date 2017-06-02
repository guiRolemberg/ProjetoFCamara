using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoFCamara.API.Models
{
    public class UsuarioModel
    {
        private string _userName;
        private string _password;
        private string _confirmPassword;

        [Required]
        [Display(Name = "Usuário")]
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        [Required]
        [StringLength(100, ErrorMessage = "A {0} tem que ter pelo menos {2} caractéres maiúsculo", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmação da Senha")]
        [Compare("Password", ErrorMessage = "A senha e a confirmação da senha devem ser iguais!")]
        public string ConfirmPassword
        {
            get { return this._confirmPassword; }
            set { this._confirmPassword = value; }
        }
    }
}