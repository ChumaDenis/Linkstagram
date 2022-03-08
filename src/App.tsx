import React from "react";
import {Router} from "./ui/boot/router/index";
import {Link } from "react-router-dom";
export default function App() {
    return (
        <div className="App">
            <header>
                <Link to="/">home</Link>
                <Link to="/about">profile</Link>
            </header>
            <Router/>
        </div>
    );
}


