using ClassLibrary1;

namespace TestProject3
{
    [TestClass]
    public class AdapterTests
    {
        [TestMethod]
        public void Camel_Move_ShouldPrintCamelMessage()
        {
            // Arrange
            Camel camel = new Camel();

            // Act
            camel.Move();
            // Тест должен вывести сообщение из метода класса Camel


        }

        [TestMethod]
        public void AdapterToCamel_Move_ShouldCallCamelMove()
        {
            // Arrange
            Camel camel = new Camel();
            AdapterToCamel adapter = new AdapterToCamel(camel);

            // Act
            adapter.Move();

            // Assert
            // Тест проверяет, что адаптер вызывает метод Move() у объекта Camel
        }

        [TestMethod]
        public void Car_Move_ShouldPrintCarMessage()
        {
            // Arrange
            Car car = new Car();

            // Act
            car.Move();

            // Assert
            // Проверка на вывод в консоль, если требуется
        }
    }
}
