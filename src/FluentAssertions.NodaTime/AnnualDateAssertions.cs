using System;
using System.Diagnostics.CodeAnalysis;
using FluentAssertions.Execution;
using FluentAssertions.Primitives;
using NodaTime;

namespace FluentAssertions.NodaTime
{
    /// <summary>
    ///     Contains assertions for <see cref="AnnualDate" />.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMethodReturnValue.Global")]
    public sealed class AnnualDateAssertions : ReferenceTypeAssertions<AnnualDate?, AnnualDateAssertions>
    {
        /// <summary>
        ///     Initializes a new <see cref="AnnualDateAssertions" />.
        /// </summary>
        /// <param name="subject">The <see cref="AnnualDate" /> that is being asserted.</param>
        /// <param name="chain"></param>
        public AnnualDateAssertions(AnnualDate? subject, AssertionChain chain)
            : base(subject, chain)
        {
        }

        /// <inheritdoc />
        [ExcludeFromCodeCoverage]
        protected override string Identifier
        {
            get => "AnnualDate";
        }

        /// <summary>
        ///     Asserts that this <see cref="AnnualDate" /> is equal to <paramref name="other" />.
        /// </summary>
        /// <param name="other">The <see cref="AnnualDate" /> to compare to.</param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;AnnualDateAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<AnnualDateAssertions> Be(AnnualDate? other, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .ForCondition(Nullable.Equals(Subject, other))
                .FailWith("Expected {context:AnnualDate} to be equal to {0}{reason}, but found {1}.", other, Subject);

            return new(this);
        }

        /// <summary>
        ///     Asserts that this <see cref="AnnualDate" /> is not equal to <paramref name="other" />.
        /// </summary>
        /// <param name="other">The <see cref="AnnualDate" /> to compare to.</param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;AnnualDateAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<AnnualDateAssertions> NotBe(AnnualDate? other, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .ForCondition(!Nullable.Equals(Subject, other))
                .FailWith("Did not expect {context:AnnualDate} to be equal to {0}{reason}, but found {1}.", other, Subject);

            return new(this);
        }

        /// <summary>
        ///     Asserts that this <see cref="AnnualDate" /> is greater than <paramref name="other" />.
        /// </summary>
        /// <param name="other">The <see cref="AnnualDate" /> to compare to.</param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;AnnualDateAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<AnnualDateAssertions> BeGreaterThan(AnnualDate other, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .ForCondition(Subject > other)
                .BecauseOf(because, becauseArgs)
                .FailWith("Expected {context:AnnualDate} to be greater than {0}{reason}, but found {1}.", other, Subject);

            return new(this);
        }

        /// <summary>
        ///     Asserts that this <see cref="AnnualDate" /> is greater than or equal to <paramref name="other" />.
        /// </summary>
        /// <param name="other">The <see cref="AnnualDate" /> to compare to.</param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;AnnualDateAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<AnnualDateAssertions> BeGreaterThanOrEqualTo(AnnualDate other, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .ForCondition(Subject >= other)
                .BecauseOf(because, becauseArgs)
                .FailWith("Expected {context:AnnualDate} to be greater than or equal to {0}{reason}, but found {1}.", other,
                    Subject);

            return new(this);
        }

        /// <summary>
        ///     Asserts that this <see cref="AnnualDate" /> is less than <paramref name="other" />.
        /// </summary>
        /// <param name="other">The <see cref="AnnualDate" /> to compare to.</param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;AnnualDateAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<AnnualDateAssertions> BeLessThan(AnnualDate other, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .ForCondition(Subject < other)
                .BecauseOf(because, becauseArgs)
                .FailWith("Expected {context:AnnualDate} to be less than {0}{reason}, but found {1}.", other, Subject);

            return new(this);
        }

        /// <summary>
        ///     Asserts that this <see cref="AnnualDate" /> is less than or equal to <paramref name="other" />.
        /// </summary>
        /// <param name="other">The <see cref="AnnualDate" /> to compare to.</param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;AnnualDateAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<AnnualDateAssertions> BeLessThanOrEqualTo(AnnualDate other, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .ForCondition(Subject <= other)
                .BecauseOf(because, becauseArgs)
                .FailWith("Expected {context:AnnualDate} to be less than or equal to {0}{reason}, but found {1}.", other,
                    Subject);

            return new(this);
        }

        /// <summary>
        ///     Asserts that this <see cref="AnnualDate" /> is a valid day and month for the specified <paramref name="year" />.
        /// </summary>
        /// <param name="year">The year to check.</param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;AnnualDateAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<AnnualDateAssertions> BeValidInYear(int year, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:AnnualDate} to be valid in year {0}{reason}", year, chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(Subject.Value.IsValidYear(year))
                            .FailWith(".");
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that this <see cref="AnnualDate" /> is not a valid day and month for the specified <paramref name="year" />.
        /// </summary>
        /// <param name="year">The year to check.</param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;AnnualDateAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<AnnualDateAssertions> NotBeValidInYear(int year, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:AnnualDate} to be valid in year {0}{reason}", year, chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(!Subject.Value.IsValidYear(year))
                            .FailWith(".");
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="AnnualDate" /> has the specified day of the month.
        /// </summary>
        /// <param name="day">
        ///     The day of the month that the current <see cref="AnnualDate" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;AnnualDateAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<AnnualDateAssertions> HaveDay(int day, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:AnnualDate} to have day {0}{reason}", day, chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(Subject.Value.Day.Equals(day))
                            .FailWith(", but found {0}.", Subject.Value.Day);
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="AnnualDate" /> does not have the specified day of the month.
        /// </summary>
        /// <param name="day">
        ///     The day of the month that the current <see cref="AnnualDate" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;AnnualDateAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<AnnualDateAssertions> NotHaveDay(int day, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:AnnualDate} to have day {0}{reason}", day, chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(!Subject.Value.Day.Equals(day))
                            .FailWith(".");
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="AnnualDate" /> has the specified month of the year.
        /// </summary>
        /// <param name="month">
        ///     The month of the year that the current <see cref="AnnualDate" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;AnnualDateAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<AnnualDateAssertions> HaveMonth(int month, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:AnnualDate} to have month {0}{reason}", month, chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(Subject.Value.Month.Equals(month))
                            .FailWith(", but found {0}.", Subject.Value.Month);
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="AnnualDate" /> does not have the specified month of the year.
        /// </summary>
        /// <param name="month">
        ///     The month of the year that the current <see cref="AnnualDate" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;AnnualDateAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<AnnualDateAssertions> NotHaveMonth(int month, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:AnnualDate} to have month {0}{reason}", month, chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(!Subject.Value.Month.Equals(month))
                            .FailWith(".");
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }
    }
}
