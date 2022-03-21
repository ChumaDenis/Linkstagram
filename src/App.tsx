import React from "react";
import {Router} from "./ui/boot/router/index";

import {Header} from "./ui/components/header"
import "./index.scss"
export default function App() {
    return (
        <div className="App">
            <Header/>
            <Router/>
        </div>
    );
}



