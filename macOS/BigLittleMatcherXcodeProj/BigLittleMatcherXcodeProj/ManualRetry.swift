//
//  ManualRetry.swift
//  BigLittleMatcherXcodeProj
//
//  Created by Steven Penava Jr. on 8/5/17.
//  Copyright © 2017 Steven Penava Jr. All rights reserved.
//

import Cocoa

class ManualRetry: NSView {
    
    @IBOutlet var PrefListTextView: NSTextView!
    
    @IBAction func AddToBigsButtonAction(_ sender: Any) {
        PrefListTextView.textStorage?.append(NSAttributedString(string: "Hello World"))
    }
    
    override func draw(_ dirtyRect: NSRect) {
        super.draw(dirtyRect)

        // Drawing code here.
    }
    
}
