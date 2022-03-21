import React from "react";
import { Routes, Route, Link } from "react-router-dom";

import HomePage from "../../pages/home";
import ProfilePage from "../../pages/profile";
import CreateAccount from "../../pages/create_account/index";
export function Router() {
    return (
        <div className="router-position">
            <Routes>
                <Route path="/" element={<HomePage />} />
                <Route path="/about" element={<ProfilePage />} />
                <Route path="/create-account" element={<CreateAccount />} />
            </Routes>
        </div>
    );
}