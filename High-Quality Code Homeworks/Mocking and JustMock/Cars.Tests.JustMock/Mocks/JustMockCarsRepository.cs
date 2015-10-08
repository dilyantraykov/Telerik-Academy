namespace Cars.Tests.JustMock.Mocks
{
    using System.Linq;

    using Cars.Contracts;
    using Cars.Models;

    using Telerik.JustMock;

    public class JustMockCarsRepository : CarRepositoryMock, ICarsRepositoryMock
    {
        protected override void ArrangeCarsRepositoryMock()
        {
            this.CarsData = Mock.Create<ICarsRepository>();
            Mock.Arrange(() => this.CarsData.Add(Arg.IsAny<Car>())).DoNothing();
            Mock.Arrange(() => this.CarsData.All()).Returns(this.FakeCarCollection);
            Mock.Arrange(() => this.CarsData.Search(Arg.AnyString))
                .Returns((string search) => this.FakeCarCollection
                    .Where(c => c.Make.ToLower() == search.ToLower() ||
                                c.Model.ToLower() == search.ToLower())
                    .ToList());
            Mock.Arrange(() => this.CarsData.Search(Arg.NullOrEmpty))
                .Returns(this.FakeCarCollection.ToList());
            Mock.Arrange(() => this.CarsData.GetById(Arg.IsInRange(1, 4, RangeKind.Inclusive))).Returns((int id) => this.FakeCarCollection.First(x => x.Id == id));
            Mock.Arrange(() => this.CarsData.GetById(Arg.IsInRange(5, int.MaxValue, RangeKind.Inclusive))).Returns(this.FakeCarCollection.First());
            Mock.Arrange(() => this.CarsData.GetById(Arg.IsInRange(int.MinValue, 0, RangeKind.Inclusive))).Returns((Car)null);
            Mock.Arrange(() => this.CarsData.SortedByMake()).Returns(this.FakeCarCollection.OrderBy(c => c.Make).ToList());
            Mock.Arrange(() => this.CarsData.SortedByYear()).Returns(this.FakeCarCollection.OrderBy(c => c.Year).ToList());
        }
    }
}
