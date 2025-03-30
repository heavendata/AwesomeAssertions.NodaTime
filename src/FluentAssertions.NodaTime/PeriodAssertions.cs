using System.Diagnostics.CodeAnalysis;
using FluentAssertions.Execution;
using FluentAssertions.Primitives;
using NodaTime;

namespace FluentAssertions.NodaTime
{
    /// <summary>
    ///     Contains assertions for <see cref="Period" />.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMethodReturnValue.Global")]
    public sealed class PeriodAssertions : ReferenceTypeAssertions<Period?, PeriodAssertions>
    {
        /// <summary>
        ///     Initializes a new <see cref="PeriodAssertions" />.
        /// </summary>
        /// <param name="subject">The <see cref="Period" /> that is being asserted.</param>
        /// <param name="chain">Assertion chain</param>
        public PeriodAssertions(Period? subject, AssertionChain chain)
            : base(subject, chain)
        {
        }

        /// <inheritdoc />
        [ExcludeFromCodeCoverage]
        protected override string Identifier
        {
            get => "Period";
        }

        /// <summary>
        ///     Asserts that this <see cref="Period" /> is equal to <paramref name="other" />.
        /// </summary>
        /// <param name="other">The <see cref="Period" /> to compare to.</param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;PeriodAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<PeriodAssertions> Be(Period? other, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .ForCondition((Subject != null && Subject.Equals(other)) || (Subject == null && other == null))
                .FailWith("Expected {context:Period} to be equal to {0}{reason}, but found {1}.", other, Subject);

            return new(this);
        }

        /// <summary>
        ///     Asserts that this <see cref="Period" /> is equal to <paramref name="other" />.
        /// </summary>
        /// <param name="other">The <see cref="Duration" /> to compare to.</param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;PeriodAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<PeriodAssertions> Be(Duration? other, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .ForCondition((Subject != null && Subject.ToDuration().Equals(other)) || (Subject == null && other == null))
                .FailWith("Expected {context:Period} to be equal to {0}{reason}, but found {1}.", other, Subject);

            return new(this);
        }

        /// <summary>
        ///     Asserts that this <see cref="Period" /> is not equal to <paramref name="other" />.
        /// </summary>
        /// <param name="other">The <see cref="Period" /> to compare to.</param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;PeriodAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<PeriodAssertions> NotBe(Period? other, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .ForCondition((Subject != null && !Subject.Equals(other)) || (Subject == null && other != null))
                .FailWith("Did not expect {context:Period} to be equal to {0}{reason}.", other, Subject);

            return new(this);
        }

        /// <summary>
        ///     Asserts that this <see cref="Period" /> is not equal to <paramref name="other" />.
        /// </summary>
        /// <param name="other">The <see cref="Duration" /> to compare to.</param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;PeriodAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<PeriodAssertions> NotBe(Duration? other, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .ForCondition((Subject != null && !Subject.ToDuration().Equals(other)) || (Subject == null && other != null))
                .FailWith("Did not expect {context:Period} to be equal to {0}{reason}.", other, Subject);

            return new(this);
        }

        /// <summary>
        ///     Asserts that this <see cref="Period" /> is zero.
        /// </summary>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;PeriodAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<PeriodAssertions> BeZero(string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .ForCondition(Subject == Period.Zero)
                .BecauseOf(because, becauseArgs)
                .FailWith("Expected {context:Period} to be zero, but found {0}.", Subject);

            return new(this);
        }

        /// <summary>
        ///     Asserts that this <see cref="Period" /> is not zero.
        /// </summary>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;PeriodAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<PeriodAssertions> NotBeZero(string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .ForCondition(Subject != Period.Zero)
                .BecauseOf(because, becauseArgs)
                .FailWith("Did not expect {context:Period} to be zero, but found {0}.", Subject);

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Period" /> has the specified seconds.
        /// </summary>
        /// <param name="seconds">
        ///     The seconds that the current <see cref="Period" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;PeriodAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<PeriodAssertions> HaveSeconds(long seconds, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:Period} to have {0} seconds{reason}", seconds, chain =>
                {
                    if (Subject != null)
                        chain
                            .ForCondition(Subject.Seconds.Equals(seconds))
                            .FailWith(", but found {0}.", Subject.Seconds);
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Period" /> does not have the specified seconds.
        /// </summary>
        /// <param name="seconds">
        ///     The seconds that the current <see cref="Period" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;PeriodAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<PeriodAssertions> NotHaveSeconds(long seconds, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:Period} to have {0} seconds{reason}", seconds, chain =>
                {
                    if (Subject != null)
                        chain
                            .ForCondition(!Subject.Seconds.Equals(seconds))
                            .FailWith(".");
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Period" /> has the specified days.
        /// </summary>
        /// <param name="days">
        ///     The days that the current <see cref="Period" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;PeriodAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<PeriodAssertions> HaveDays(int days, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:Period} to have {0} days{reason}", days, chain =>
                {
                    if (Subject != null)
                        chain
                            .ForCondition(Subject.Days.Equals(days))
                            .FailWith(", but found {0}.", Subject.Days);
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Period" /> does not have the specified days.
        /// </summary>
        /// <param name="days">
        ///     The days that the current <see cref="Period" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;PeriodAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<PeriodAssertions> NotHaveDays(int days, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:Period} to have {0} days{reason}", days, chain =>
                {
                    if (Subject != null)
                        chain
                            .ForCondition(!Subject.Days.Equals(days))
                            .FailWith(".");
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

                return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Period" /> has the specified months.
        /// </summary>
        /// <param name="months">
        ///     The months that the current <see cref="Period" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;PeriodAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<PeriodAssertions> HaveMonths(int months, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:Period} to have {0} months{reason}", months, chain =>
                {
                    if (Subject != null)
                        chain
                            .ForCondition(Subject.Months.Equals(months))
                            .FailWith(", but found {0}.", Subject.Months);
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Period" /> does not have the specified months.
        /// </summary>
        /// <param name="months">
        ///     The months that the current <see cref="Period" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;PeriodAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<PeriodAssertions> NotHaveMonths(int months, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:Period} to have {0} months{reason}", months, chain =>
                {
                    if (Subject != null)
                        chain
                            .ForCondition(!Subject.Months.Equals(months))
                            .FailWith(".");
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Period" /> has the specified weeks.
        /// </summary>
        /// <param name="weeks">
        ///     The weeks that the current <see cref="Period" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;PeriodAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<PeriodAssertions> HaveWeeks(int weeks, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:Period} to have {0} weeks{reason}", weeks, chain =>
                {
                    if (Subject != null)
                        chain
                            .ForCondition(Subject.Weeks.Equals(weeks))
                            .FailWith(", but found {0}.", Subject.Weeks);
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Period" /> does not have the specified weeks.
        /// </summary>
        /// <param name="weeks">
        ///     The weeks that the current <see cref="Period" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;PeriodAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<PeriodAssertions> NotHaveWeeks(int weeks, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:Period} to have {0} weeks{reason}", weeks, chain =>
                {
                    if (Subject != null)
                        chain
                            .ForCondition(!Subject.Weeks.Equals(weeks))
                            .FailWith(".");
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Period" /> has the specified years.
        /// </summary>
        /// <param name="years">
        ///     The years that the current <see cref="Period" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;PeriodAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<PeriodAssertions> HaveYears(int years, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:Period} to have {0} years{reason}", years, chain =>
                {
                    if (Subject != null)
                        chain
                            .ForCondition(Subject.Years.Equals(years))
                            .FailWith(", but found {0}.", Subject.Years);
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Period" /> does not have the specified years.
        /// </summary>
        /// <param name="years">
        ///     The years that the current <see cref="Period" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;PeriodAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<PeriodAssertions> NotHaveYears(int years, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:Period} to have {0} years{reason}", years, chain =>
                {
                    if (Subject != null)
                        chain
                            .ForCondition(!Subject.Years.Equals(years))
                            .FailWith(".");
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Period" /> has the specified milliseconds.
        /// </summary>
        /// <param name="milliseconds">
        ///     The milliseconds that the current <see cref="Period" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;PeriodAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<PeriodAssertions> HaveMilliseconds(long milliseconds, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:Period} to have {0} milliseconds{reason}", milliseconds, chain =>
                {
                    if (Subject != null)
                        chain
                            .ForCondition(Subject.Milliseconds.Equals(milliseconds))
                            .FailWith(", but found {0}.", Subject.Milliseconds);
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Period" /> does not have the specified milliseconds.
        /// </summary>
        /// <param name="milliseconds">
        ///     The milliseconds that the current <see cref="Period" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;PeriodAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<PeriodAssertions> NotHaveMilliseconds(long milliseconds, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:Period} to have {0} milliseconds{reason}", milliseconds, chain =>
                {
                    if (Subject != null)
                        chain
                            .ForCondition(!Subject.Milliseconds.Equals(milliseconds))
                            .FailWith(".");
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Period" /> has the specified nanoseconds.
        /// </summary>
        /// <param name="nanoseconds">
        ///     The nanoseconds that the current <see cref="Period" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;PeriodAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<PeriodAssertions> HaveNanoseconds(long nanoseconds, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:Period} to have {0} nanoseconds{reason}", nanoseconds, chain =>
                {
                    if (Subject != null)
                        chain
                            .ForCondition(Subject.Nanoseconds.Equals(nanoseconds))
                            .FailWith(", but found {0}.", Subject.Nanoseconds);
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Period" /> does not have the specified nanoseconds.
        /// </summary>
        /// <param name="nanoseconds">
        ///     The nanoseconds that the current <see cref="Period" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;PeriodAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<PeriodAssertions> NotHaveNanoseconds(long nanoseconds, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:Period} to have {0} nanoseconds{reason}", nanoseconds, chain =>
                {
                    if (Subject != null)
                        chain
                            .ForCondition(!Subject.Nanoseconds.Equals(nanoseconds))
                            .FailWith(".");
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Period" /> has the specified minutes.
        /// </summary>
        /// <param name="minutes">
        ///     The minutes that the current <see cref="Period" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;PeriodAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<PeriodAssertions> HaveMinutes(long minutes, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:Period} to have {0} minutes{reason}", minutes, chain =>
                {
                    if (Subject != null)
                        chain
                            .ForCondition(Subject.Minutes.Equals(minutes))
                            .FailWith(", but found {0}.", Subject.Minutes);
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Period" /> does not have the specified minutes.
        /// </summary>
        /// <param name="minutes">
        ///     The minutes that the current <see cref="Period" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;PeriodAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<PeriodAssertions> NotHaveMinutes(long minutes, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:Period} to have {0} minutes{reason}", minutes, chain =>
                {
                    if (Subject != null)
                        chain
                            .ForCondition(!Subject.Minutes.Equals(minutes))
                            .FailWith(".");
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Period" /> has the specified ticks.
        /// </summary>
        /// <param name="ticks">
        ///     The ticks that the current <see cref="Period" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;PeriodAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<PeriodAssertions> HaveTicks(long ticks, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:Period} to have {0} ticks{reason}", ticks, chain =>
                {
                    if (Subject != null)
                        chain
                            .ForCondition(Subject.Ticks.Equals(ticks))
                            .FailWith(", but found {0}.", Subject.Ticks);
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Period" /> does not have the specified ticks.
        /// </summary>
        /// <param name="ticks">
        ///     The ticks that the current <see cref="Period" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;PeriodAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<PeriodAssertions> NotHaveTicks(long ticks, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:Period} to have {0} ticks{reason}", ticks, chain =>
                {
                    if (Subject != null)
                        chain
                            .ForCondition(!Subject.Ticks.Equals(ticks))
                            .FailWith(".");
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Period" /> has the specified hours.
        /// </summary>
        /// <param name="hours">
        ///     The hours that the current <see cref="Period" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;PeriodAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<PeriodAssertions> HaveHours(long hours, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:Period} to have {0} hours{reason}", hours, chain =>
                {
                    if (Subject != null)
                        chain
                            .ForCondition(Subject.Hours.Equals(hours))
                            .FailWith(", but found {0}.", Subject.Hours);
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Period" /> does not have the specified hours.
        /// </summary>
        /// <param name="hours">
        ///     The hours that the current <see cref="Period" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;PeriodAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<PeriodAssertions> NotHaveHours(long hours, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:Period} to have {0} hours{reason}", hours, chain =>
                {
                    if (Subject != null)
                        chain
                            .ForCondition(!Subject.Hours.Equals(hours))
                            .FailWith(".");
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Period" /> has any non-zero date-based properties (days or higher).
        /// </summary>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;PeriodAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<PeriodAssertions> HaveDateComponent(string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:Period} to have a date component{reason}", chain =>
                {
                    if (Subject != null)
                        chain
                            .ForCondition(Subject.HasDateComponent)
                            .FailWith(".");
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Period" /> does not have any non-zero date-based properties (days or higher).
        /// </summary>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;PeriodAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<PeriodAssertions> NotHaveDateComponent(string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:Period} to have a date component{reason}", chain =>
                {
                    if (Subject != null)
                        chain
                            .ForCondition(!Subject.HasDateComponent)
                            .FailWith(".");
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Period" /> has any non-zero time-based properties (hours or lower).
        /// </summary>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;PeriodAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<PeriodAssertions> HaveTimeComponent(string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:Period} to have a time component{reason}", chain =>
                {
                    if (Subject != null)
                        chain
                            .ForCondition(Subject.HasTimeComponent)
                            .FailWith(".");
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Period" /> does not have any non-zero time-based properties (hours or lower).
        /// </summary>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;PeriodAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<PeriodAssertions> NotHaveTimeComponent(string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:Period} to have a time component{reason}", chain =>
                {
                    if (Subject != null)
                        chain
                            .ForCondition(!Subject.HasTimeComponent)
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
