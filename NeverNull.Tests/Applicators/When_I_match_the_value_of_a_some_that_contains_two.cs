﻿using System;
using Machine.Specifications;

namespace NeverNull.Tests.Applicators {
    [Subject(typeof (NeverNull.Applicators), "Match")]
    internal class When_I_match_the_value_of_a_some_that_contains_two {
        static Option<int> _some;
        static int _two;

        static Action<int> _whenSome;
        static bool _isNone;
        static Action _whenNone;

        Establish context = () => {
            _some = Option.Some(2);

            _whenSome = i => _two = i;
            _whenNone = () => _isNone = true;
        };

        Because of = () => _some.Match(
            _whenSome,
            _whenNone);

        It should_execute_the_some_callback_and_return_two = () => _two.ShouldEqual(2);

        It should_not_execute_the_none_callback = () => _isNone.ShouldBeFalse();
    }
}