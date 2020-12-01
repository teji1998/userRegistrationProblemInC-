using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace userRegistrationProblem
{
    public class UserDetails
    {

        /// <summary>
        /// Gets or sets the firstame.
        /// </summary>
        /// <value>
        /// The firstame.
        /// </value>
        [Required(ErrorMessage = "Name{0} is required")]
        [RegularExpression("^[A-Z]{1}[a-z]{2,}$", ErrorMessage = "Name which is entered is invalid")]
        [StringLength(50,MinimumLength = 3, ErrorMessage ="Name should consist of atleast 3 characters")]
        public string Firstame { get; set; }

        [Required(ErrorMessage = "Name{0} is required")]
        [RegularExpression("^[A-Z]{1}[a-z]{2,}$", ErrorMessage = "Name which is entered is invalid")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name should consist of atleast 3 characters")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>
        /// The number.
        /// </value>
        [Required(ErrorMessage = "MobileNumber{0} is required")]
        [RegularExpression("^[0-9]{2}\\s[6-9]{1}[0-9]{9}", ErrorMessage = "Mobile number entered is invalid")]
        [StringLength(13, ErrorMessage = "MobileNumber should also contain the country code")]
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [Required(ErrorMessage = "Email{0} is required")]
        [RegularExpression("^[0-9a-z]+[+_.-]?[0-9a-z]+[@][0-9a-z]+[.][a-z]{2,}[.]?[a-z]+$", ErrorMessage = "Email entered is not valid")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        [Required(ErrorMessage = "Password{0} is required")]
        [RegularExpression("^(?=.*[A-Z].*)(?=.*[0-9].*)(?=.*[@#$%^&*+_].*)[0-9a-zA-Z@#$%^&*+_]{8,}", ErrorMessage = "Password entered is invalid")]
        [StringLength(40, MinimumLength = 8,ErrorMessage = "Password should contain atleast 8 characters")]
        public string Password { get; set; }
    }
}
