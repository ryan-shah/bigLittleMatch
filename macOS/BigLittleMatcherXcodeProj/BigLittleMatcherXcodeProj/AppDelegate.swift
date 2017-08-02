//
//  AppDelegate.swift
//  BigLittleMatcherXcodeProj
//
//  Created by Steven Penava Jr. on 7/31/17.
//  Copyright © 2017 Steven Penava Jr. All rights reserved.
//

import Cocoa

@NSApplicationMain
class AppDelegate: NSObject, NSApplicationDelegate {


    @IBOutlet weak var ExportMatchesMenuItem: NSMenuItem!

    func applicationDidFinishLaunching(_ aNotification: Notification) {
        ExportMatchesMenuItem.target = self
        ExportMatchesMenuItem.isEnabled = false
    }

    func applicationWillTerminate(_ aNotification: Notification) {
        // Insert code here to tear down your application
    }


}

