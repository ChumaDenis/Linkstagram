import React from "react";
import {Link } from "react-router-dom";

import "../style/header.scss"

export function Header() {
    return (
        <header>
            <div className="header_container">
                <Link to="/" className="header_logo">Linkstagram</Link>
                <div className="header_container_button">
                    <Link to='/create-account'>
                        <button className="header_home_button">
                            Home
                        </button>
                    </Link>
                    <button className="header_language_button" >
                        EN
                    </button>
                    <Link to='/profile'>
                        <img src="" alt=""/>
                    </Link>
                </div>
            </div>
        </header>

    );
}