'use client';

import { useState, useEffect, useRef } from 'react';
import { ChevronDown, ChevronUp } from 'lucide-react';
import Input from './input/input';
import Card from './card/card';
import Option from './option/option';

import styles from './dropdown.module.css';
import { DropdownOption } from '@/Interfaces/DropdownOption';



interface DropdownSelectClientProps {
    options: DropdownOption[];
}

export default function DropdownSelect({ options }: DropdownSelectClientProps) {
    const [filteredOptions, setFilteredOptions] = useState<DropdownOption[]>(options);
    const [selected, setSelected] = useState<DropdownOption | null>(null);
    const [isOpen, setIsOpen] = useState<boolean>(false);
    const [search, setSearch] = useState<string>('');
    const dropdownRef = useRef<HTMLDivElement>(null);

    useEffect(() => {
        setFilteredOptions(
            options.filter((option) =>
                option.label.toLowerCase().includes(search.toLowerCase())   
            )
        );
    }, [search, options]);

    const handleSelect = (option: DropdownOption) => {
        setSelected(option);
        setIsOpen(false);
        setSearch('');
        console.log("Item selected")
    };

    const handleClickOutside = (event: MouseEvent) => {
        if (dropdownRef.current && !dropdownRef.current.contains(event.target as Node)) {
            setIsOpen(false);
        }
    };

    useEffect(() => {
        document.addEventListener('mousedown', handleClickOutside);
        return () => {
            document.removeEventListener('mousedown', handleClickOutside);
        };
    }, []);

    return (
        <div className={styles['dropdown']} ref={dropdownRef}>
            <label className={styles['dropdown-label']}>
                {selected ? selected.label : 'Select a family of the list'}
            </label>
            <div className={styles['dropdown-input']} onClick={() => setIsOpen(!isOpen)}>
                <Input
                    placeholder="Search..."
                    value={search}
                    onChange={(e) => setSearch(e.target.value)}
                    onClick={(e) => e.stopPropagation()}
                />
                {isOpen ? <ChevronUp /> : <ChevronDown />}
            </div>
            {isOpen && (
                <Card>
                    {filteredOptions.length > 0 ? (
                        filteredOptions.map((option) => (
                            <Option
                                key={option.value}
                                isSelected={selected?.value === option.value}
                                onClick={() => handleSelect(option)}>
                                {option.label}
                            </Option>
                        ))
                    ) : (
                        <div className={styles['dropdown-no-options']}>No options found</div>
                    )}
                </Card>
            )}
        </div>
    );
}