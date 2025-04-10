﻿using System;
using System.Diagnostics.CodeAnalysis;
using FluentAssertions.Execution;
using FluentAssertions.Primitives;
using NodaTime;
using NodaTime.Calendars;

namespace FluentAssertions.NodaTime
{
    /// <summary>
    ///     Contains assertions for <see cref="OffsetDateTime" />.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMethodReturnValue.Global")]
    public sealed class OffsetDateTimeAssertions : ReferenceTypeAssertions<OffsetDateTime?, OffsetDateTimeAssertions>
    {
        /// <summary>
        ///     Initializes a new <see cref="OffsetDateTimeAssertions" />.
        /// </summary>
        /// <param name="subject">The <see cref="OffsetDateTime" /> that is being asserted.</param>
        /// <param name="chain">Assertion chain</param>
        public OffsetDateTimeAssertions(OffsetDateTime? subject, AssertionChain chain)
            : base(subject, chain)
        {
        }

        /// <inheritdoc />
        [ExcludeFromCodeCoverage]
        protected override string Identifier
        {
            get => "OffsetDateTime";
        }

        /// <summary>
        ///     Asserts that this <see cref="OffsetDateTime" /> is equal to <paramref name="other" />.
        /// </summary>
        /// <param name="other">The <see cref="OffsetDateTime" /> to compare to.</param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> Be(OffsetDateTime? other, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .ForCondition(Nullable.Equals(Subject, other))
                .FailWith("Expected {context:OffsetDateTime} to be equal to {0}{reason}, but found {1}.", other, Subject);

            return new(this);
        }

        /// <summary>
        ///     Asserts that this <see cref="OffsetDateTime" /> is not equal to <paramref name="other" />.
        /// </summary>
        /// <param name="other">The <see cref="OffsetDateTime" /> to compare to.</param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> NotBe(OffsetDateTime? other, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .ForCondition(!Nullable.Equals(Subject, other))
                .FailWith("Did not expect {context:OffsetDateTime} to be equal to {0}{reason}.", other);

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> has the specified <see cref="CalendarSystem" />.
        /// </summary>
        /// <param name="calendar">
        ///     The <see cref="CalendarSystem" /> that the current <see cref="OffsetDateTime" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An
        ///     <see cref="AndWhichConstraint{TParentConstraint, TMatchedElement}">
        ///         AndWhichConstraint&lt;OffsetDateTimeAssertions,
        ///         CalendarSystem&gt;
        ///     </see>
        ///     which can be used to assert the <see cref="CalendarSystem" />.
        /// </returns>
        [CustomAssertion]
        public AndWhichConstraint<OffsetDateTimeAssertions, CalendarSystem> BeInCalendar(CalendarSystem calendar,
            string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:OffsetDateTime} to be in calendar {0}{reason}", calendar, chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(Subject.Value.Calendar.Equals(calendar))
                            .FailWith(", but found {0}.", Subject.Value.Calendar);
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this, calendar);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> does not have the specified <see cref="CalendarSystem" />.
        /// </summary>
        /// <param name="calendar">
        ///     The <see cref="CalendarSystem" /> that the current <see cref="OffsetDateTime" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> NotBeInCalendar(CalendarSystem calendar, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:OffsetDateTime} to be in calendar {0}{reason}", calendar, chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(!Subject.Value.Calendar.Equals(calendar))
                            .FailWith(".");
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> has the specified <see cref="OffsetDate" />.
        /// </summary>
        /// <param name="date">
        ///     The <see cref="LocalDate" /> that the current <see cref="OffsetDateTime" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An
        ///     <see cref="AndWhichConstraint{TParentConstraint, TMatchedElement}">
        ///         AndWhichConstraint&lt;OffsetDateTimeAssertions, LocalDate
        ///         &gt;
        ///     </see>
        ///     which can be used to assert the <see cref="OffsetDate" />.
        /// </returns>
        [CustomAssertion]
        public AndWhichConstraint<OffsetDateTimeAssertions, LocalDate> HaveDate(LocalDate date, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:OffsetDateTime} to have date {0}{reason}", date, chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(Subject.Value.Date.Equals(date))
                            .FailWith(", but found {0}.", Subject.Value.Date);
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this, date);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> does not have the specified <see cref="OffsetDate" />.
        /// </summary>
        /// <param name="date">
        ///     The <see cref="LocalDate" /> that the current <see cref="OffsetDateTime" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> NotHaveDate(LocalDate date, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:OffsetDateTime} to have date {0}{reason}", date, chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(!Subject.Value.Date.Equals(date))
                            .FailWith(".");
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> has the specified <see cref="LocalDateTime" />.
        /// </summary>
        /// <param name="localDateTime">
        ///     The <see cref="LocalDateTime" /> that the current <see cref="OffsetDateTime" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An
        ///     <see cref="AndWhichConstraint{TParentConstraint, TMatchedElement}">
        ///         AndWhichConstraint&lt;OffsetDateTimeAssertions,
        ///         LocalDateTime&gt;
        ///     </see>
        ///     which can be used to assert the <see cref="OffsetDate" />.
        /// </returns>
        [CustomAssertion]
        public AndWhichConstraint<OffsetDateTimeAssertions, LocalDateTime> HaveLocalDateTime(LocalDateTime localDateTime,
            string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:OffsetDateTime} to have local date time {0}{reason}", localDateTime,
                    chain =>
                    {
                        if (Subject.HasValue)
                            chain
                                .ForCondition(Subject.Value.LocalDateTime.Equals(localDateTime))
                                .FailWith(", but found {0}.", Subject.Value.LocalDateTime);
                        else
                            chain
                                .ForCondition(false)
                                .FailWith(", but found <null>.");
                    });

            return new(this, localDateTime);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> does not have the specified <see cref="LocalDateTime" />.
        /// </summary>
        /// <param name="date">
        ///     The <see cref="LocalDateTime" /> that the current <see cref="OffsetDateTime" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> NotHaveLocalDateTime(LocalDateTime date, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:OffsetDateTime} to have local date time {0}{reason}", date, chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(!Subject.Value.LocalDateTime.Equals(date))
                            .FailWith(".");
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> has the specified <see cref="Offset" />.
        /// </summary>
        /// <param name="offset">
        ///     The <see cref="OffsetDateTime" /> that the current <see cref="OffsetDateTime" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An
        ///     <see cref="AndWhichConstraint{TParentConstraint, TMatchedElement}">
        ///         AndWhichConstraint&lt;OffsetDateTimeAssertions,
        ///         OffsetDateTime&gt;
        ///     </see>
        ///     which can be used to assert the <see cref="OffsetDateTime" />.
        /// </returns>
        [CustomAssertion]
        public AndWhichConstraint<OffsetDateTimeAssertions, Offset> HaveOffset(Offset offset, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:OffsetDateTime} to have offset {0}{reason}", offset, chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(Subject.Value.Offset.Equals(offset))
                            .FailWith(", but found {0}.", Subject.Value.Offset);
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this, offset);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> has the specified <see cref="TimeSpan" />.
        /// </summary>
        /// <param name="timeSpan">
        ///     The <see cref="OffsetDateTime" /> that the current <see cref="OffsetDateTime" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An
        ///     <see cref="AndWhichConstraint{TParentConstraint, TMatchedElement}">
        ///         AndWhichConstraint&lt;OffsetDateTimeAssertions,
        ///         OffsetDateTime&gt;
        ///     </see>
        ///     which can be used to assert the <see cref="OffsetDateTime" />.
        /// </returns>
        [CustomAssertion]
        public AndWhichConstraint<OffsetDateTimeAssertions, Offset> HaveOffset(TimeSpan timeSpan, string because = "",
            params object[] becauseArgs) =>
            HaveOffset(Offset.FromTimeSpan(timeSpan), because, becauseArgs);

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> does not have the specified <see cref="Offset" />.
        /// </summary>
        /// <param name="offset">
        ///     The <see cref="OffsetDateTime" /> that the current <see cref="OffsetDateTime" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> NotHaveOffset(Offset offset, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:OffsetDateTime} to have offset {0}{reason}", offset, chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(!Subject.Value.Offset.Equals(offset))
                            .FailWith(".");
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> does not have the specified <see cref="TimeSpan" />.
        /// </summary>
        /// <param name="timeSpan">
        ///     The <see cref="OffsetDateTime" /> that the current <see cref="OffsetDateTime" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> NotHaveOffset(TimeSpan timeSpan, string because = "",
            params object[] becauseArgs) =>
            NotHaveOffset(Offset.FromTimeSpan(timeSpan), because, becauseArgs);

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> has the specified <see cref="OffsetTime" />.
        /// </summary>
        /// <param name="timeOfDay">
        ///     The <see cref="LocalTime" /> that the current <see cref="OffsetDateTime" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An
        ///     <see cref="AndWhichConstraint{TParentConstraint, TMatchedElement}">
        ///         AndWhichConstraint&lt;OffsetDateTimeAssertions, LocalTime
        ///         &gt;
        ///     </see>
        ///     which can be used to assert the <see cref="OffsetTime" />.
        /// </returns>
        [CustomAssertion]
        public AndWhichConstraint<OffsetDateTimeAssertions, LocalTime> HaveTimeOfDay(LocalTime timeOfDay, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:OffsetDateTime} to have time of day {0}{reason}", timeOfDay, chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(Subject.Value.TimeOfDay.Equals(timeOfDay))
                            .FailWith(", but found {0}.", Subject.Value.TimeOfDay);
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this, timeOfDay);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> does not have the specified <see cref="OffsetTime" />.
        /// </summary>
        /// <param name="timeOfDay">
        ///     The <see cref="LocalTime" /> that the current <see cref="OffsetDateTime" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> NotHaveTimeOfDay(LocalTime timeOfDay, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:OffsetDateTime} to have time of day {0}{reason}", timeOfDay, chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(!Subject.Value.TimeOfDay.Equals(timeOfDay))
                            .FailWith(".");
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> has the specified hour of the half-day.
        /// </summary>
        /// <param name="clockHourOfHalfDay">
        ///     The hour of the half-day that the current <see cref="OffsetDateTime" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> HaveClockHourOfHalfDay(int clockHourOfHalfDay, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:OffsetDateTime} to have clock hour of the half-day of {0}{reason}",
                    clockHourOfHalfDay, chain =>
                    {
                        if (Subject.HasValue)
                            chain
                                .ForCondition(Subject.Value.ClockHourOfHalfDay.Equals(clockHourOfHalfDay))
                                .FailWith(", but found {0}.", Subject.Value.ClockHourOfHalfDay);
                        else
                            chain
                                .ForCondition(false)
                                .FailWith(", but found <null>.");
                    });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> does not have the specified hour of the half-day.
        /// </summary>
        /// <param name="clockHourOfHalfDay">
        ///     The hour of the half-day that the current <see cref="OffsetDateTime" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> NotHaveClockHourOfHalfDay(int clockHourOfHalfDay, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:OffsetDateTime} to have clock hour of the half-day of {0}{reason}",
                    clockHourOfHalfDay, chain =>
                    {
                        if (Subject.HasValue)
                            chain
                                .ForCondition(!Subject.Value.ClockHourOfHalfDay.Equals(clockHourOfHalfDay))
                                .FailWith(".");
                        else
                            chain
                                .ForCondition(false)
                                .FailWith(", but found <null>.");
                    });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> has the specified day of the month.
        /// </summary>
        /// <param name="day">
        ///     The day of the month that the current <see cref="OffsetDateTime" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> HaveDay(int day, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:OffsetDateTime} to have day {0}{reason}", day, chain =>
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
        ///     Asserts that the current <see cref="OffsetDateTime" /> does not have the specified day of the month.
        /// </summary>
        /// <param name="day">
        ///     The day of the month that the current <see cref="OffsetDateTime" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> NotHaveDay(int day, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:OffsetDateTime} to have day {0}{reason}", day, chain =>
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
        ///     Asserts that the current <see cref="OffsetDateTime" /> has the specified day of the week.
        /// </summary>
        /// <param name="dayOfWeek">
        ///     The day of the week that the current <see cref="OffsetDateTime" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> HaveDayOfWeek(IsoDayOfWeek dayOfWeek, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:OffsetDateTime} to have day of week {0}{reason}", dayOfWeek, chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(Subject.Value.DayOfWeek.Equals(dayOfWeek))
                            .FailWith(", but found {0}.", Subject.Value.DayOfWeek);
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> does not have the specified day of the week.
        /// </summary>
        /// <param name="dayOfWeek">
        ///     The day of the week that the current <see cref="OffsetDateTime" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> NotHaveDayOfWeek(IsoDayOfWeek dayOfWeek, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:OffsetDateTime} to have day of week {0}{reason}", dayOfWeek,
                    chain =>
                    {
                        if (Subject.HasValue)
                            chain
                                .ForCondition(!Subject.Value.DayOfWeek.Equals(dayOfWeek))
                                .FailWith(".");
                        else
                            chain
                                .ForCondition(false)
                                .FailWith(", but found <null>.");
                    });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> has the specified day of the year.
        /// </summary>
        /// <param name="dayOfYear">
        ///     The day of the year that the current <see cref="OffsetDateTime" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> HaveDayOfYear(int dayOfYear, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:OffsetDateTime} to have day of year {0}{reason}", dayOfYear, chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(Subject.Value.DayOfYear.Equals(dayOfYear))
                            .FailWith(", but found {0}.", Subject.Value.DayOfYear);
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> does not have the specified day of the year.
        /// </summary>
        /// <param name="dayOfYear">
        ///     The day of the year that the current <see cref="OffsetDateTime" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> NotHaveDayOfYear(int dayOfYear, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:OffsetDateTime} to have day of year {0}{reason}", dayOfYear,
                    chain =>
                    {
                        if (Subject.HasValue)
                            chain
                                .ForCondition(!Subject.Value.DayOfYear.Equals(dayOfYear))
                                .FailWith(".");
                        else
                            chain
                                .ForCondition(false)
                                .FailWith(", but found <null>.");
                    });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> has the specified hour of the day.
        /// </summary>
        /// <param name="hourOfDay">
        ///     The hour of the day that the current <see cref="OffsetDateTime" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> HaveHour(int hourOfDay, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:OffsetDateTime} to have hour of day {0}{reason}", hourOfDay, chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(Subject.Value.Hour.Equals(hourOfDay))
                            .FailWith(", but found {0}.", Subject.Value.Hour);
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> does not have the specified hour of the day.
        /// </summary>
        /// <param name="hourOfDay">
        ///     The hour of the day that the current <see cref="OffsetDateTime" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> NotHaveHour(int hourOfDay, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:OffsetDateTime} to have hour of day {0}{reason}", hourOfDay,
                    chain =>
                    {
                        if (Subject.HasValue)
                            chain
                                .ForCondition(!Subject.Value.Hour.Equals(hourOfDay))
                                .FailWith(".");
                        else
                            chain
                                .ForCondition(false)
                                .FailWith(", but found <null>.");
                    });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> has the specified year.
        /// </summary>
        /// <param name="year">
        ///     The year that the current <see cref="OffsetDateTime" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> HaveYear(int year, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:OffsetDateTime} to have year {0}{reason}", year, chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(Subject.Value.Year.Equals(year))
                            .FailWith(", but found {0}.", Subject.Value.Year);
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> does not have the specified year.
        /// </summary>
        /// <param name="year">
        ///     The year that the current <see cref="OffsetDateTime" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> NotHaveYear(int year, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:OffsetDateTime} to have year {0}{reason}", year, chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(!Subject.Value.Year.Equals(year))
                            .FailWith(".");
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> has the specified second.
        /// </summary>
        /// <param name="second">
        ///     The second that the current <see cref="OffsetDateTime" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> HaveSecond(int second, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:OffsetDateTime} to have second {0}{reason}", second, chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(Subject.Value.Second.Equals(second))
                            .FailWith(", but found {0}.", Subject.Value.Second);
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> does not have the specified second.
        /// </summary>
        /// <param name="second">
        ///     The second that the current <see cref="OffsetDateTime" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> NotHaveSecond(int second, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:OffsetDateTime} to have second {0}{reason}", second, chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(!Subject.Value.Second.Equals(second))
                            .FailWith(".");
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> has the specified month.
        /// </summary>
        /// <param name="month">
        ///     The month that the current <see cref="OffsetDateTime" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> HaveMonth(int month, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:OffsetDateTime} to have month {0}{reason}", month, chain =>
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
        ///     Asserts that the current <see cref="OffsetDateTime" /> does not have the specified month.
        /// </summary>
        /// <param name="month">
        ///     The month that the current <see cref="OffsetDateTime" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> NotHaveMonth(int month, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:OffsetDateTime} to have month {0}{reason}", month, chain =>
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

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> has the specified minute.
        /// </summary>
        /// <param name="minute">
        ///     The minute that the current <see cref="OffsetDateTime" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> HaveMinute(int minute, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:OffsetDateTime} to have minute {0}{reason}", minute, chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(Subject.Value.Minute.Equals(minute))
                            .FailWith(", but found {0}.", Subject.Value.Minute);
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> does not have the specified minute.
        /// </summary>
        /// <param name="minute">
        ///     The minute that the current <see cref="OffsetDateTime" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> NotHaveMinute(int minute, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:OffsetDateTime} to have minute {0}{reason}", minute, chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(!Subject.Value.Minute.Equals(minute))
                            .FailWith(".");
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> has the specified millisecond.
        /// </summary>
        /// <param name="millisecond">
        ///     The millisecond that the current <see cref="OffsetDateTime" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> HaveMillisecond(int millisecond, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:OffsetDateTime} to have millisecond {0}{reason}", millisecond, chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(Subject.Value.Millisecond.Equals(millisecond))
                            .FailWith(", but found {0}.", Subject.Value.Millisecond);
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> does not have the specified millisecond.
        /// </summary>
        /// <param name="millisecond">
        ///     The millisecond that the current <see cref="OffsetDateTime" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> NotHaveMillisecond(int millisecond, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:OffsetDateTime} to have millisecond {0}{reason}", millisecond,
                    chain =>
                    {
                        if (Subject.HasValue)
                            chain
                                .ForCondition(!Subject.Value.Millisecond.Equals(millisecond))
                                .FailWith(".");
                        else
                            chain
                                .ForCondition(false)
                                .FailWith(", but found <null>.");
                    });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> has the specified nanoseconds within the day.
        /// </summary>
        /// <param name="nanosecondOfDay">
        ///     The nanoseconds within the day that the current <see cref="OffsetDateTime" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> HaveNanosecondsWithinDay(long nanosecondOfDay, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:OffsetDateTime} to have {0} nanoseconds within the day{reason}",
                    nanosecondOfDay, chain =>
                    {
                        if (Subject.HasValue)
                            chain
                                .ForCondition(Subject.Value.NanosecondOfDay.Equals(nanosecondOfDay))
                                .FailWith(", but found {0}.", Subject.Value.NanosecondOfDay);
                        else
                            chain
                                .ForCondition(false)
                                .FailWith(", but found <null>.");
                    });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> does not have the specified nanoseconds within the day.
        /// </summary>
        /// <param name="nanosecondOfDay">
        ///     The nanoseconds within the day that the current <see cref="OffsetDateTime" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> NotHaveNanosecondsWithinDay(long nanosecondOfDay, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:OffsetDateTime} to have {0} nanoseconds within the day{reason}",
                    nanosecondOfDay, chain =>
                    {
                        if (Subject.HasValue)
                            chain
                                .ForCondition(!Subject.Value.NanosecondOfDay.Equals(nanosecondOfDay))
                                .FailWith(".");
                        else
                            chain
                                .ForCondition(false)
                                .FailWith(", but found <null>.");
                    });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> has the specified nanoseconds within the second.
        /// </summary>
        /// <param name="nanosecondOfSecond">
        ///     The nanoseconds within the second that the current <see cref="OffsetDateTime" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> HaveNanosecondsWithinSecond(int nanosecondOfSecond, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:OffsetDateTime} to have {0} nanoseconds within the second{reason}",
                    nanosecondOfSecond, chain =>
                    {
                        if (Subject.HasValue)
                            chain
                                .ForCondition(Subject.Value.NanosecondOfSecond.Equals(nanosecondOfSecond))
                                .FailWith(", but found {0}.", Subject.Value.NanosecondOfSecond);
                        else
                            chain
                                .ForCondition(false)
                                .FailWith(", but found <null>.");
                    });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> does not have the specified nanoseconds within the second.
        /// </summary>
        /// <param name="nanosecondOfSecond">
        ///     The nanoseconds within the second that the current <see cref="OffsetDateTime" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> NotHaveNanosecondsWithinSecond(int nanosecondOfSecond, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:OffsetDateTime} to have {0} nanoseconds within the second{reason}",
                    nanosecondOfSecond, chain =>
                    {
                        if (Subject.HasValue)
                            chain
                                .ForCondition(!Subject.Value.NanosecondOfSecond.Equals(nanosecondOfSecond))
                                .FailWith(".");
                        else
                            chain
                                .ForCondition(false)
                                .FailWith(", but found <null>.");
                    });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> has the specified tick of second.
        /// </summary>
        /// <param name="tickOfSecond">
        ///     The tick of second that the current <see cref="OffsetDateTime" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> HaveTicksWithinSecond(int tickOfSecond, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:OffsetDateTime} to have {0} ticks within the second{reason}",
                    tickOfSecond, chain =>
                    {
                        if (Subject.HasValue)
                            chain
                                .ForCondition(Subject.Value.TickOfSecond.Equals(tickOfSecond))
                                .FailWith(", but found {0}.", Subject.Value.TickOfSecond);
                        else
                            chain
                                .ForCondition(false)
                                .FailWith(", but found <null>.");
                    });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> does not have the specified tick of second.
        /// </summary>
        /// <param name="tickOfSecond">
        ///     The tick of second that the current <see cref="OffsetDateTime" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> NotHaveTicksWithinSecond(int tickOfSecond, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:OffsetDateTime} to have {0} ticks within the second{reason}",
                    tickOfSecond, chain =>
                    {
                        if (Subject.HasValue)
                            chain
                                .ForCondition(!Subject.Value.TickOfSecond.Equals(tickOfSecond))
                                .FailWith(".");
                        else
                            chain
                                .ForCondition(false)
                                .FailWith(", but found <null>.");
                    });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> has the specified tick of day.
        /// </summary>
        /// <param name="tickOfDay">
        ///     The tick of day that the current <see cref="OffsetDateTime" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> HaveTicksWithinDay(long tickOfDay, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:OffsetDateTime} to have {0} ticks within the day{reason}", tickOfDay,
                    chain =>
                    {
                        if (Subject.HasValue)
                            chain
                                .ForCondition(Subject.Value.TickOfDay.Equals(tickOfDay))
                                .FailWith(", but found {0}.", Subject.Value.TickOfDay);
                        else
                            chain
                                .ForCondition(false)
                                .FailWith(", but found <null>.");
                    });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> does not have the specified tick of day.
        /// </summary>
        /// <param name="tickOfDay">
        ///     The tick of day that the current <see cref="OffsetDateTime" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> NotHaveTicksWithinDay(long tickOfDay, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:OffsetDateTime} to have {0} ticks within the day{reason}",
                    tickOfDay, chain =>
                    {
                        if (Subject.HasValue)
                            chain
                                .ForCondition(!Subject.Value.TickOfDay.Equals(tickOfDay))
                                .FailWith(".");
                        else
                            chain
                                .ForCondition(false)
                                .FailWith(", but found <null>.");
                    });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> has the specified year of era.
        /// </summary>
        /// <param name="yearOfEra">
        ///     The year of era that the current <see cref="OffsetDateTime" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> HaveYearWithinEra(int yearOfEra, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:OffsetDateTime} to have {0} as the year within the era{reason}",
                    yearOfEra, chain =>
                    {
                        if (Subject.HasValue)
                            chain
                                .ForCondition(Subject.Value.YearOfEra.Equals(yearOfEra))
                                .FailWith(", but found {0}.", Subject.Value.YearOfEra);
                        else
                            chain
                                .ForCondition(false)
                                .FailWith(", but found <null>.");
                    });

             return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> does not have the specified year of era.
        /// </summary>
        /// <param name="yearOfEra">
        ///     The year of era that the current <see cref="OffsetDateTime" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> NotHaveYearWithinEra(int yearOfEra, string because = "",
            params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:OffsetDateTime} to have {0} as the year within the era{reason}",
                    yearOfEra, chain =>
                    {
                        if (Subject.HasValue)
                            chain
                                .ForCondition(!Subject.Value.YearOfEra.Equals(yearOfEra))
                                .FailWith(".");
                        else
                            chain
                                .ForCondition(false)
                                .FailWith(", but found <null>.");
                    });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> has the specified era.
        /// </summary>
        /// <param name="era">
        ///     The era that the current <see cref="OffsetDateTime" /> is expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> HaveEra(Era era, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected {context:OffsetDateTime} to have era {0}{reason}", era, chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(Subject.Value.Era.Equals(era))
                            .FailWith(", but found {0}.", Subject.Value.Era);
                    else
                        chain
                            .ForCondition(false)
                            .FailWith(", but found <null>.");
                });

            return new(this);
        }

        /// <summary>
        ///     Asserts that the current <see cref="OffsetDateTime" /> does not have the specified era.
        /// </summary>
        /// <param name="era">
        ///     The era that the current <see cref="OffsetDateTime" /> is not expected to have.
        /// </param>
        /// <param name="because">
        ///     A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        ///     is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        ///     Zero or more objects to format using the placeholders in <paramref name="because" />.
        /// </param>
        /// <returns>
        ///     An <see cref="AndConstraint{T}">AndConstraint&lt;OffsetDateTimeAssertions&gt;</see> which can be used to chain assertions.
        /// </returns>
        [CustomAssertion]
        public AndConstraint<OffsetDateTimeAssertions> NotHaveEra(Era era, string because = "", params object[] becauseArgs)
        {
            CurrentAssertionChain
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Did not expect {context:OffsetDateTime} to have era {0}{reason}", era, chain =>
                {
                    if (Subject.HasValue)
                        chain
                            .ForCondition(!Subject.Value.Era.Equals(era))
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
