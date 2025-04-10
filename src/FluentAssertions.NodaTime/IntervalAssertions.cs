﻿using System;
using System.Diagnostics.CodeAnalysis;
using FluentAssertions.Execution;
using FluentAssertions.Primitives;
using NodaTime;

namespace FluentAssertions.NodaTime
{
    /// <summary>
    ///     Contains assertions for <see cref="Interval" />.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMethodReturnValue.Global")]
    public sealed class IntervalAssertions : ReferenceTypeAssertions<Interval?, IntervalAssertions>
    {
        /// <summary>
        ///     Initializes a new <see cref="IntervalAssertions" />.
        /// </summary>
        /// <param name="subject">The <see cref="Interval" /> that is being asserted.</param>
        /// <param name="chain">Assertion chain</param>
        public IntervalAssertions(Interval? subject, AssertionChain chain)
            : base(subject, chain)
        {
        }

        /// <inheritdoc />
        [ExcludeFromCodeCoverage]
        protected override string Identifier
        {
            get => "Interval";
        }

        /// <summary>
        ///     Asserts that this <see cref="Interval" /> is equal to <paramref name="other" />.
        /// </summary>
        /// <param name="other">The <see cref="Interval" /> to compare to.</param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;IntervalAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<IntervalAssertions> Be(Interval? other, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .ForCondition(Nullable.Equals(Subject, other))
                .FailWith("Expected {context:Interval} to be equal to {0}{reason}, but found {1}.", other, Subject);

            return new(this);
        }

        /// <summary>
        ///     Asserts that this <see cref="Interval" /> is not equal to <paramref name="other" />.
        /// </summary>
        /// <param name="other">The <see cref="Interval" /> to compare to.</param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;IntervalAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<IntervalAssertions> NotBe(Interval? other, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .ForCondition(!Nullable.Equals(Subject, other))
                .FailWith("Did not expect {context:Interval} to be equal to {0}{reason}.", other);

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Interval" /> has the specified duration.
        /// </summary>
        /// <param name="duration">
        ///     The duration that the current <see cref="Interval" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;IntervalAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<IntervalAssertions> HaveDuration(Duration duration, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:Interval} to have a duration of {0}{reason}", duration, chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(Subject.Value.Duration.Equals(duration))
                            .FailWith(", but found {0}.", Subject.Value.Duration);
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Interval" /> has the specified duration.
        /// </summary>
        /// <param name="duration">
        ///     The duration that the current <see cref="Interval" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;IntervalAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<IntervalAssertions> NotHaveDuration(Duration duration, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:Interval} to have a duration of {0}{reason}", duration, chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(!Subject.Value.Duration.Equals(duration))
                            .FailWith(".");
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Interval" /> has a fixed end point.
        /// </summary>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;IntervalAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<IntervalAssertions> End(string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:Interval} to have an end{reason}", chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(Subject.Value.HasEnd)
                            .FailWith(".");
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Interval" /> does not have a fixed end point.
        /// </summary>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;IntervalAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<IntervalAssertions> NotEnd(string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:Interval} to have an end{reason}", chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(!Subject.Value.HasEnd)
                            .FailWith(", but found {0}.", () => Subject.Value.End);
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Interval" /> ends at <paramref name="instant" />.
        /// </summary>
        /// <param name="instant">The exclusive upper bound of the interval.</param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;IntervalAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<IntervalAssertions> EndAt(Instant? instant, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:Interval} to end at {0}{reason}", instant, chain =>
                {
                    if (Subject == null)
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                    else if (Subject.Value.HasEnd)
                        chain
                            .ForCondition(Subject.Value.End.Equals(instant))
                            .FailWith(", but {context:Interval} ends at {0}.", Subject.Value.End);
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but {context:Interval} does not end.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Interval" /> does not end at <paramref name="instant" />.
        /// </summary>
        /// <param name="instant">The exclusive upper bound of the interval.</param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;IntervalAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<IntervalAssertions> NotEndAt(Instant? instant, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:Interval} to end at {0}{reason}", instant, chain =>
                {
                    if (Subject == null)
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                    else if (Subject.Value.HasEnd)
                        chain
                            .ForCondition(!Subject.Value.End.Equals(instant))
                            .FailWith(".");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Interval" /> has a fixed start point.
        /// </summary>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepstarted automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;IntervalAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<IntervalAssertions> Start(string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:Interval} to have a start{reason}", chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(Subject.Value.HasStart)
                            .FailWith(".");
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Interval" /> does not have a fixed start point.
        /// </summary>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepstarted automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;IntervalAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<IntervalAssertions> NotStart(string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:Interval} to have a start{reason}", chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(!Subject.Value.HasStart)
                            .FailWith(", but found {0}.", () => Subject.Value.Start);
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

           return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Interval" /> starts at <paramref name="instant" />.
        /// </summary>
        /// <param name="instant">The inclusive lower bound of the interval.</param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepstarted automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;IntervalAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<IntervalAssertions> StartAt(Instant? instant, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:Interval} to start at {0}{reason}", instant, chain =>
                {
                    if (Subject == null)
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                    else if (Subject.Value.HasStart)
                        chain
                            .ForCondition(Subject.Value.Start.Equals(instant))
                            .FailWith(", but {context:Interval} starts at {0}.", Subject.Value.Start);
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but {context:Interval} does not start.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Interval" /> does not start at <paramref name="instant" />.
        /// </summary>
        /// <param name="instant">The inclusive lower bound of the interval.</param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepstarted automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;IntervalAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<IntervalAssertions> NotStartAt(Instant? instant, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:Interval} to start at {0}{reason}", instant, chain =>
                {
                    if (Subject == null)
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                    else if (Subject.Value.HasStart)
                        chain
                            .ForCondition(!Subject.Value.Start.Equals(instant))
                            .FailWith(".");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Interval" /> contains <paramref name="instant" />.
        /// </summary>
        /// <param name="instant">The inclusive lower bound of the interval.</param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not contain with the word <i>because</i>, it is prepcontained automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;IntervalAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<IntervalAssertions> Contain(Instant instant, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:Interval} to contain {0}{reason}", instant, chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(Subject.Value.Contains(instant))
                            .FailWith(".");
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="Interval" /> does not contain <paramref name="instant" />.
        /// </summary>
        /// <param name="instant">The inclusive lower bound of the interval.</param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not contain with the word <i>because</i>, it is prepcontained automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;IntervalAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<IntervalAssertions> NotContain(Instant instant, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:Interval} to contain {0}{reason}", instant, chain =>
                {
                    if (Subject == null)
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                    else
                        chain
                            .ForCondition(!Subject.Value.Contains(instant))
                            .FailWith(".");
                });

            return new(this);
        }
    }
}
