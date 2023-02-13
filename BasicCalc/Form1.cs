using System.Net.Http.Headers;

namespace BasicCalc
{
    /// <summary>
    /// A basic calculator
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        #endregion
        #region Clearing Methods
        /// <summary>
        /// Clears the user input text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            //Clears the text from the user input text box
            this.UserInputText.Text = string.Empty;
            //Focus the user input text
            FocusInputText();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            //Delete the value after the selected position
            DeleteTextValue();
           
            //focus the user input text
            FocusInputText();
        }
        #endregion
        #region Operator Methods
        private void DivideButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");
            FocusInputText();
        }

        private void TimesButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");
            FocusInputText();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");
            FocusInputText();
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");
            FocusInputText();
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            CalculateEquation();
            FocusInputText();
        }
        #endregion
        #region Number Methods
        private void SevenButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");
            FocusInputText();
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");
            FocusInputText();
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");
            FocusInputText();
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");
            FocusInputText();
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");
            FocusInputText();
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");
            FocusInputText();
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");
            FocusInputText();
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");
            FocusInputText();
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");
            FocusInputText();
        }
        /// <summary>
        /// Defines 0 button action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");
            FocusInputText();
        }
        private void DotButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");
            FocusInputText();
        }
        #endregion
        /// <summary>
        /// Calculates the current equation and puts an answer to the user label
        /// </summary>
        private void CalculateEquation()
        {
            //TO DO: Finish


            this.CalculationResultText.Text = ParseOperation();
            // 2. New Class Files
            // 3. Recursive functions
            // 4. Switch statements

            //Focus the user input text
            FocusInputText();
        }
        /// <summary>
        /// Pases the user equation and calculates result
        /// </summary>
        /// <returns></returns>
        private string ParseOperation()
        {
           try
            {
                // Get the user equation input
                var input = this.UserInputText.Text;

                // Remove all spases
                input = input.Replace(" ", "");

                // Create a new top-level operation
                var operation = new Operation();
                var leftSide = true;
                
                //Loop through each character in input starting from left working to the right
                for (int i = 0; i < input.Length; i++)
                {
                    // TODO: Handle order priority
                    // 4 + 5 * 3
                    // It should calculate 5 * 3 first, and then add 4 to the result (basic math)

                    // check if the current character is a number
                    if ("0123456789.".Any(c => input[i] == c))
                    {
                        if (leftSide)
                        {
                            operation.LeftSide = AddNumberPart(operation.LeftSide, input[i]);
                        }
                        else
                        {
                            operation.RightSide = AddNumberPart(operation.RightSide, input[i]);
                        }
                    }
                    // If it is an operator ( + - * / ) and if it is, we want to set a type
                    else if ("+-*/".Any(c => input[i] == c))
                    {
                        // If we are on the right side, we need to calculate our current operation
                        // and set the result to the left side of the next operation 
                        if (!leftSide)
                        {
                            //Get the operator type
                            var operatorType = GetOperationType(input[i]);
                            //Check if we actually havve a right side number
                            if (operation.RightSide.Length == 0)
                            {
                                //Check the operator is not a minus (as there could be a negative number)
                                if (operatorType != OperationType.Minus)
                                {
                                    throw new InvalidOperationException($"Operator (*, +, /, or more than one -) is not valid in this case");
                                }
                                // If we got here, the operator type is a -, and there isnor right side number, so add the minus to the number
                                operation.RightSide += input[i];
                            }
                            else
                            {
                                // Calculate previous equation and set it to the left side
                                operation.LeftSide = CalculateOperation(operation);

                                //Set new operator
                                operation.OperationType = operatorType;

                                //Clear the previous right number
                                operation.RightSide = string.Empty;

                                 
                            }
                        }
                        else
                        {
                            //Get the operator type
                            var operatorType = GetOperationType(input[i]);
                            //Check if we actually havve a left side number
                            if (operation.LeftSide.Length == 0)
                            {
                                //Check the operator is not a minus (as there could be a negative number)
                                if (operatorType != OperationType.Minus)
                                {
                                    throw new InvalidOperationException($"Operator (*, +, /, or more than one -) is not valid in this case");
                                }
                                // If we got here, the operator type is a -, and there isnor left side number, so add the minus to the number
                                operation.LeftSide += input[i];
                            }
                            else
                            {
                                // If we get here, we have a left number and an operator, so we want to move to the right side

                                // Set the operation type
                                operation.OperationType = operatorType;

                                //Move to the right side
                                leftSide = false;
                            }
                        }
                    }
                }

                // If we are done parsing, and there were no exceptions
                // Calculate the current operation
                return CalculateOperation(operation);
            }
            catch(Exception ex) 
            {
                return $"Invalid equation. {ex.Message}";
            }
        }

        /// <summary>
        /// Calculates an <see cref="Operation"/> and returns the result
        /// </summary>
        /// <param name="operation">The operation to calculate</param>
        private string CalculateOperation(Operation operation)
        {
            // Store the number values of the string representations
            decimal left = 0;
            decimal right = 0;

            // Check if we have a valid left side number
            if (string.IsNullOrEmpty(operation.LeftSide) || !decimal.TryParse(operation.LeftSide, out left))
                throw new InvalidOperationException($"Left side of the operation is not a number {operation.LeftSide}");

            // Check if we have a valid right side number
            if (string.IsNullOrEmpty(operation.RightSide) || !decimal.TryParse(operation.RightSide, out right))
                throw new InvalidOperationException($"Left side of the operation is not a number {operation.RightSide}");

            try
            {
                switch (operation.OperationType)
                {
                    case OperationType.Add:
                        return (left + right).ToString();
                    case OperationType.Minus:
                        return (left - right).ToString();
                    case OperationType.Divide:
                        return (left / right).ToString();
                    case OperationType.Multiply:
                        return (left * right).ToString();
                        default: throw new InvalidOperationException($"Unknown operator type when calculating operation. {operation.OperationType}");

                }
            }
            catch (Exception ex) 
            {
                throw new InvalidOperationException($"Failed to calculate operation {operation.LeftSide} {operation.OperationType} {operation.RightSide}. {ex.Message}");
            }
        }

        /// <summary>
        /// Accepts a cxharacter and returns known <see cref="OperationType"/> 
        /// </summary>
        /// <param name="character">The character to parse</param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        private OperationType GetOperationType(char character)
        {
            switch (character) 
            {
                case '+':
                    return OperationType.Add;
                    
                case '-':
                    return OperationType.Minus;
                    
                case '*':
                    return OperationType.Multiply;
                    
                case '/':
                    return OperationType.Divide;
                default:
                    throw new InvalidOperationException($"Unknown operator type {character}");
            }
        }
        /// <summary>
        /// Attempts to add a new character to the current number, chacking for valid characters as it goes 
        /// </summary>
        /// <param name="currentNumber"> The current number string </param>
        /// <param name="newCharacter"> The new character to append to the string</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private string AddNumberPart(string currentNumber, char newCharacter)
        {
            // Check if there is already a dot in the number
            if (newCharacter == '.' && currentNumber.Contains('.'))
                throw new InvalidOperationException($"Number {currentNumber} already contains a . and another can't be added");
            return currentNumber + newCharacter;
        }
        #region Private helpers
        /// <summary>
        /// Focuses the user input text
        /// </summary>
        private void FocusInputText()
        {
            this.UserInputText.Focus();
        }
        /// <summary>
        /// Deletes the character to the right of the selection of the user imput text box
        /// </summary>
        private void DeleteTextValue()
        {
            // If we don't have a value to delete, return 
            if (this.UserInputText.Text.Length < this.UserInputText.SelectionStart + 1)
                return; 
            // Remember the selection start
            var selectionStart = this.UserInputText.SelectionStart;

            // Delete the character to the right of the selection 
                this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);

            //Restore the selection start
            this.UserInputText.SelectionStart = selectionStart;

            //Restore selection length to zero
            this.UserInputText.SelectionLength = 0;
        }
        /// <summary>
        /// Inserts user input to the user input box
        /// </summary>
        /// <param name="value">The value to insert</param>
        private void InsertTextValue(string value)
        {
            var selectionStart = this.UserInputText.SelectionStart;
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, value);
            this.UserInputText.SelectionStart = selectionStart + value.Length;
            this.UserInputText.SelectionLength = 0;
        }
        #endregion
    }
}