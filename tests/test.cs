using System.Collections.Generic;
using WebApi.ActiveQueryBuilder.Api;
using WebApi.ActiveQueryBuilder.Model;
using WebApi.ActiveQueryBuilder.Client;
using NUnit.Framework;

namespace QueryBuilderApi.csclient
{
    [TestFixture]
    public class UnitTest1
    {
        private ActiveQueryBuilderApi _api;
        private Transform _transform;
        private string _guid = "b3207f4f-b1f4-4dc2-979b-7724ed2d0221";
        private string _sql = "select customer_id, first_name, last_name, create_date from customer";

        [SetUp]
        public void SetUp()
        {
            _api = new ActiveQueryBuilderApi();
            _transform = new Transform
            {
                Guid = _guid,
                Sql = _sql
            };   
        }

        [TearDown]
        public void TearDown()
        {
            _api = null;
            _transform = null;
        }

        [Test]
        public void Avg()
        {
            //Arrange
            var avg = new Totals { Field = "first_name", Aggregate = Totals.AggregateEnum.Avg };

            _transform.Totals = new List<Totals> { avg };
            
            //Act
            var result = _api.TransformSQLPost(_transform);
            
            //Assert
            var correct = "Select Avg(q.first_name) as first_nameavg From (Select customer.customer_id customer_id, customer.first_name first_name, customer.last_name last_name, customer.create_date create_date From customer) q";
            Assert.AreEqual(correct.ToLower(), result.Totals.ToLower());
        }

        [Test]
        public void Count()
        {
            //Arrange
            var count = new Totals { Field = "first_name", Aggregate = Totals.AggregateEnum.Count };

            _transform.Totals = new List<Totals> { count };

            //Act
            var result = _api.TransformSQLPost(_transform);

            //Assert
            var correct = "Select Count(q.first_name) as first_namecount From (Select customer.customer_id customer_id, customer.first_name first_name, customer.last_name last_name, customer.create_date create_date From customer) q";
            Assert.AreEqual(correct.ToLower(), result.Totals.ToLower());
        }

        [Test]
        public void Max()
        {
            //Arrange
            var max = new Totals { Field = "first_name", Aggregate = Totals.AggregateEnum.Max };

            _transform.Totals = new List<Totals> { max };

            //Act
            var result = _api.TransformSQLPost(_transform);

            //Assert
            var correct = "Select Max(q.first_name) as first_namemax From (Select customer.customer_id customer_id, customer.first_name first_name, customer.last_name last_name, customer.create_date create_date From customer) q";
            Assert.AreEqual(correct.ToLower(), result.Totals.ToLower());
        }

        [Test]
        public void Min()
        {
            //Arrange
            var min = new Totals { Field = "first_name", Aggregate = Totals.AggregateEnum.Min };

            _transform.Totals = new List<Totals> { min };

            //Act
            var result = _api.TransformSQLPost(_transform);

            //Assert
            var correct = "Select Min(q.first_name) as first_namemin From (Select customer.customer_id customer_id, customer.first_name first_name, customer.last_name last_name, customer.create_date create_date From customer) q";
            Assert.AreEqual(correct.ToLower(), result.Totals.ToLower());
        }

        [Test]
        public void Sum()
        {
            //Arrange
            var sum = new Totals { Field = "first_name", Aggregate = Totals.AggregateEnum.Sum };

            _transform.Totals = new List<Totals> { sum };

            //Act
            var result = _api.TransformSQLPost(_transform);

            //Assert
            var correct = "Select Sum(q.first_name) as first_namesum From (Select customer.customer_id customer_id, customer.first_name first_name, customer.last_name last_name, customer.create_date create_date From customer) q";
            Assert.AreEqual(correct.ToLower(), result.Totals.ToLower());
        }

        [Test]
        public void Order()
        {
            //Arrange
            var asc = new Sorting { Field = "customer_id", Order = Sorting.OrderEnum.Asc };

            _transform.Sortings = new List<Sorting> { asc };

            //Act
            var result = _api.TransformSQLPost(_transform);

            //Assert
            var correct = "Select customer.customer_id, customer.first_name, customer.last_name, customer.create_date From customer order by customer.customer_id";
            Assert.AreEqual(correct.ToLower(), result.Sql.ToLower());
        }

        [Test]
        public void OrderDesc()
        {
            //Arrange
            var desc = new Sorting { Field = "customer_id", Order = Sorting.OrderEnum.Desc };

            _transform.Sortings = new List<Sorting> { desc };

            //Act
            var result = _api.TransformSQLPost(_transform);

            //Assert
            var correct = "Select customer.customer_id, customer.first_name, customer.last_name, customer.create_date From customer order by customer.customer_id desc";
            Assert.AreEqual(correct.ToLower(), result.Sql.ToLower());
        }

        [Test]
        public void Pagination()
        {
            //Arrange
            var page = new Pagination { Skip = 2, Take = 3 };

            _transform.Pagination = page;

            //Act
            var result = _api.TransformSQLPost(_transform);

            //Assert
            var correct = "select customer.customer_id, customer.first_name, customer.last_name, customer.create_date from customer limit 3 offset 2";
            Assert.AreEqual(correct.ToLower(), result.Sql.ToLower());
        }

        [Test]
        public void HiddenColumn()
        {
            //Arrange
            var column = new HiddenColumn { Field = "first_name" };

            _transform.HiddenColumns = new List<HiddenColumn> { column };

            //Act
            var result = _api.TransformSQLPost(_transform);

            //Assert
            var correct = "select q.customer_id, q.last_name, q.create_date from (select customer.customer_id customer_id, customer.first_name first_name, customer.last_name last_name, customer.create_date create_date from customer) q";
            Assert.AreEqual(correct.ToLower(), result.Sql.ToLower());
        }

        [Test]
        public void FilterContains()
        {
            //Arrange
            var filter = new ConditionGroup();

            var condition = new Condition { Field = "first_name", ConditionOperator = Condition.ConditionOperatorEnum.Contains, Values = new List<string> { "Orlando" } };

            filter.Conditions = new List<Condition> { condition };

            _transform.Filter = filter;

            //Act
            var result = _api.TransformSQLPost(_transform);

            //Assert
            var correct = "select customer.customer_id, customer.first_name, customer.last_name, customer.create_date from customer where customer.first_name like '%Orlando%'";
            Assert.AreEqual(correct.ToLower(), result.Sql.ToLower());
        }

        [Test]
        public void FilterLess()
        {
            //Arrange
            var filter = new ConditionGroup();

            var condition = new Condition { Field = "customer_id", ConditionOperator = Condition.ConditionOperatorEnum.Less, Values = new List<string> { "5" } };

            filter.Conditions = new List<Condition> { condition };

            _transform.Filter = filter;

            //Act
            var result = _api.TransformSQLPost(_transform);

            //Assert
            var correct = "select customer.customer_id, customer.first_name, customer.last_name, customer.create_date from customer where customer.customer_id < 5";
            Assert.AreEqual(correct.ToLower(), result.Sql.ToLower());
        }

        [Test]
        public void FilterBetween()
        {
            //Arrange
            var filter = new ConditionGroup();

            var condition = new Condition { Field = "customer_id", ConditionOperator = Condition.ConditionOperatorEnum.Between, Values = new List<string> { "1", "5" } };

            filter.Conditions = new List<Condition> { condition };

            _transform.Filter = filter;

            //Act
            var result = _api.TransformSQLPost(_transform);

            //Assert
            var correct = "select customer.customer_id, customer.first_name, customer.last_name, customer.create_date from customer where customer.customer_id between 1 and 5";
            Assert.AreEqual(correct.ToLower(), result.Sql.ToLower(), result.Error);
        }

        [Test]
        public void ConditionGroup()
        {
            //Arrange
            var filter = new ConditionGroup();

            var conditionGroup = new ConditionGroup();

            var condition1 = new Condition { Field = "customer_id", ConditionOperator = Condition.ConditionOperatorEnum.IsNull };
            var condition2 = new Condition { Field = "customer_id", ConditionOperator = Condition.ConditionOperatorEnum.IsNotNull };
            
            conditionGroup.Conditions = new List<Condition> { condition1, condition2 };

            filter.ConditionGroups = new List<ConditionGroup> { conditionGroup };

            _transform.Filter = filter;

            //Act
            var result = _api.TransformSQLPost(_transform);

            //Assert
            var correct = "select customer.customer_id, customer.first_name, customer.last_name, customer.create_date from customer where ((customer.customer_id is null) or (customer.customer_id is not null))";
            Assert.AreEqual(correct.ToLower(), result.Sql.ToLower(), result.Error);
        }

        [Test]
        public void InvalidColumn()
        {
            //Arrange
            var filter = new ConditionGroup();

            var condition = new Condition { Field = "id1", ConditionOperator = Condition.ConditionOperatorEnum.Between, Values = new List<string> { "1" } };

            filter.Conditions = new List<Condition> { condition };

            _transform.Filter = filter;

            //Act
            var result = _api.TransformSQLPost(_transform);

            //Assert
            var correct = "QueryTransformer does't contain id1";
            Assert.AreEqual(correct.ToLower(), result.Error.ToLower());
        }

	[Test]
        public void GetFields()
        {
            //Arrange
            SqlQuery query = new SqlQuery
	        {
		      Guid = _guid,
		      Text = _sql
	        };
					
            //Act
            var fields = _api.GetQueryColumnsPost(query);

            //Assert
            Assert.AreEqual(fields.Count, 4);
            Assert.AreEqual("customer_id", fields[0].Name);
	    Assert.AreEqual("smallint", fields[0].DataType);
            Assert.AreEqual("create_date", fields[3].Name);
	    Assert.AreEqual("datetime", fields[3].DataType);
        }
    }
}
