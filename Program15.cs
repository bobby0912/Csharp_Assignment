//using c__Assignment;

//**Use of Delegates for Event Handling**

//Create a `Button` class that has a delegate `OnClick`. Implement an event that triggers when the button is clicked.



using System;

namespace c__Assignment
{
    class Button
    {
        // Define a delegate for the click event
        public delegate void ClickHandler();

        // Define an event based on the delegate
        public event ClickHandler OnClick;

        // Method to simulate a button click
        public void Click()
        {
            Console.WriteLine("Button clicked.");
            // Trigger the event
            OnClick?.Invoke();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Button button = new Button();

            // Subscribe to the OnClick event
            button.OnClick += Button_OnClick;

            // Simulate a button click
            button.Click();
        }

        // Event handler method
        private static void Button_OnClick()
        {
            Console.WriteLine("Button click event handler executed.");
        }
    }
}

